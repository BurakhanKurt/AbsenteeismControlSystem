using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Abstract;

namespace Repositories.Layer.Concretes
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }

        //Kullanıcının Tum derslerini getiren method
        public async Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges)
        {
            var courses = await GetById(c => c.UserId == userId, trackChanges)
                .ToListAsync();
            return courses;
        }

        //Kullanıcının tum derslerini güne bağlı getiren method
        public async Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId, int dayId, bool trackChanges)
        {
            var courses = await GetById(u => u.UserId == userId,trackChanges).
                Include(c => c.CourseCalendars).
                    ThenInclude(d => d.Day).
                Where(d => d.CourseCalendars.Any(d => d.DayId == dayId)).
                ToListAsync();
            return courses;
        }

        //Kullanıcının bir dersinin detayını ve saatini getiren method
        public async Task<Course?> GetOneCourseByIdWithDetailAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await GetById(u => u.UserId == userId,trackChanges)
                .Where(c => c.Id == courseId).
                Include(d => d.CourseDetail).SingleOrDefaultAsync();
            return course;
        }

        //Kullanıcının bir dersinin hangi gunlerde oldugunu getiren method
        public async Task<Course?> GetOneCourseByIdWithDaysAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await 
                GetById(c => c.Id == courseId,trackChanges).
                Include(c => c.CourseCalendars)
                    .ThenInclude(d => d.Day)
                .SingleOrDefaultAsync(u => u.UserId == userId);
            return course;
        }

        //Kullanıcının bir dersini getiren method
        public async Task<Course?> GetOneCourseByIdAsync(int userId, int courseId, bool trackChanges)
        {
            var course = await GetById(c => c.Id == courseId, trackChanges).
                SingleOrDefaultAsync(u => u.UserId == userId);
            return course;
        }

        public void CreateOneCourse(Course course) => Create(course);

        public void UpdateOneCourse(Course course) => Update(course);

        public void DeleteOneCourse(Course course) => Delete(course);

    }
}
