using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }
        
        //Kullanıcının Tum derslerini getiren method
        public async Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges)
        {
            var courses = await GetByCondition(c => c.UserId == userId, trackChanges)
                .ToListAsync();
            return courses;
        }

        //Kullanıcının bır gundekı derslerını getıren method
        public async Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId, int dayId, bool trackChanges)
        {
            var courses = await GetByCondition(u => u.UserId == userId, trackChanges).
                Include(c => c.CourseCalendars).
                    ThenInclude(d => d.Day.DayName).
                Where(d => d.CourseCalendars.Any(d => d.DayId == dayId)).
                ToListAsync();
            return courses;
        }

        //Kullanıcının bir dersinin detayını ve saatini getiren method
        public async Task<Course?> GetOneCourseByIdWithDetailAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await GetByCondition(u => u.UserId == userId, trackChanges)
                .Where(c => c.Id == courseId).
                Include(d => d.CourseDetail).
                    Include(c=> c.CourseCalendars.Select( d => new
                    {
                        d.StartTime , d.EndTime
                    }))
                .SingleOrDefaultAsync();
            return course;
        }

        //Kullanıcının bir dersinin hangi gunlerde oldugunu getiren method
        public async Task<Course?> GetOneCourseByIdWithDaysAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await
                GetByCondition(c => c.Id == courseId, trackChanges).
                Include(c => c.CourseCalendars)
                    .ThenInclude(d => d.Day.DayName)
                .SingleOrDefaultAsync(u => u.UserId == userId);
            return course;
        }

        //Kullanıcının bir dersini getiren method
        public async Task<Course?> GetOneCourseByIdAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges).
                SingleOrDefaultAsync(u => u.UserId == userId);
            return course;
        }

        public void CreateOneCourse(Course course) => Create(course);
        public void UpdateOneCourse(Course course) => Update(course);
        public void DeleteOneCourse(Course course) => Delete(course);
    }
}
