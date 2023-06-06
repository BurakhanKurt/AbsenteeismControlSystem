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
        public async Task<Course?> GetOneCourseByIdWithDetailAsync( int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges)
                .Include(d => d.CourseDetail)
                    .Include(c=> c.CourseCalendars.Select( d => new
                    {
                        d.StartTime , d.EndTime
                    }))
                .SingleOrDefaultAsync();
            return course;
        }

        //dersin hangi gunlerde oldugunu getiren method
        public async Task<Course?> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges)
        {
            var course = await
                GetByCondition(c => c.Id == courseId, trackChanges).
                Include(c => c.CourseCalendars)
                    .ThenInclude(d => d.Day.DayName)
                .SingleOrDefaultAsync();
            return course;
        }

        //bir dersi getiren method
        public async Task<Course?> GetOneCourseByIdAsync(int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges).
                SingleOrDefaultAsync();
            return course;
        }

        public void CreateOneCourse(Course course) => Create(course);
        public void UpdateOneCourse(Course course, bool trackChanges) => Update(course);
        public void DeleteOneCourse(Course course, bool trackChanges) => Delete(course);
    }
}
