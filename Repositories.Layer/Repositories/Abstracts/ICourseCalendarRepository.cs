using Entities.Layer.Models;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface ICourseCalendarRepository : IRepositoryBase<CourseCalendar>
    {
        Task<IEnumerable<CourseCalendar>> GetAllCourseCalendarAsync(int courseId, bool trackChanges);
        Task<CourseCalendar> GetOneCourseCalendarByIdAsync(int courseId, byte dayId, bool trackChanges);
        Task CreateOneCourseCalendarAsync(CourseCalendar courseCalendar);
        void UpdateOneCourseCalendar(CourseCalendar courseCalendar);
        void DeleteOneCourseCalendar(CourseCalendar courseCalendar);
    }
}
