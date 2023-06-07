using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class CourseCalenderManager : ICourseCalendarService
    {
        private readonly IRepositoryManager _manager;
        public CourseCalenderManager(IRepositoryManager manager)
        {
            _manager=manager;
        }

        public async Task DeleteOneCourseCalendar(int courseId, int dayId, bool trackChanges)
        {
            var courseCalendar = await _manager
                .CourseCalendar.
                GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);
            // Todo hata yönetimi yapılacak

            _manager.CourseCalendar.DeleteOneCourseCalendar(courseCalendar);
            await _manager.SaveAsync();
        }

        public async Task UpdateOneCourseCalendarAsync(int courseId, int dayId, CourseCalendar courseCalendar, bool trackChanges)
        {
            var entity = await _manager
                .CourseCalendar
                .GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);
            // Todo Hata yönetimi yapılacak

            // Todo AutoMapper kullanılacaks
            entity.StartTime = courseCalendar.StartTime;
            entity.EndTime = courseCalendar.EndTime;
            entity.DayId = courseCalendar.DayId;
            entity.UpdateDate = DateTime.Now;

            _manager.CourseCalendar.UpdateOneCourseCalendar(entity);
            await _manager.SaveAsync();
        }
    }
}
