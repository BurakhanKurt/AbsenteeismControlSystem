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

        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        public async Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges)
        {
            var courses = await GetByCondition(c => c.UserId == userId, trackChanges).Include(x => x.CourseDetail)
                .ToListAsync();
            return courses;
        }

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        public async Task<IEnumerable<Course>> GetAllUserCoursesByDayAndTimeAsync(int userId, int dayId, bool trackChanges)
        {
        var courses = await GetByCondition(c => c.UserId == userId && c.CourseCalendars.Any(c => c.DayId==dayId), trackChanges)
        .Include(c => c.CourseCalendars.Where(cc => cc.DayId == dayId))
        .ToListAsync();
            return courses;
        }

        // Detaylarıyla birlikte belirli bir kursu asenkron olarak getirir
        public async Task<Course> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges)
                .Include(d => d.CourseDetail)
                .Include(c => c.CourseCalendars.Select(d => new { d.StartTime, d.EndTime }))
                .SingleOrDefaultAsync();
            return course;
        }

        // Günleri ile birlikte belirli bir kursu asenkron olarak getirir
        public async Task<Course> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges)
                .Include(c => c.CourseCalendars)
                    .ThenInclude(d => d.Day.DayName)
                .SingleOrDefaultAsync();
            return course;
        }

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        public async Task<Course> GetOneCourseByIdAsync(int courseId, bool trackChanges)
        {
            var course = await GetByCondition(c => c.Id == courseId, trackChanges).Include(x=> x.CourseDetail)
                .SingleOrDefaultAsync();
            return course;
        }

        // Bir kursu senkron olarak oluşturur
        public void CreateOneCourse(Course course) => Create(course);
        
        // Bir kursu asenkron olarak oluşturur
        public async Task CreateOneCourseAsync(Course course) => await CreateAsync(course);
        
        // Bir kursu günceller
        public void UpdateOneCourse(Course course) => Update(course);

        // Bir kursu siler
        public void DeleteOneCourse(Course course) => Delete(course);

        
    }
}
