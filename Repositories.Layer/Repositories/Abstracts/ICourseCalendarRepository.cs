
using Entities.Models;

namespace Repositories.Repositories.Abstracts
{
    public interface ICourseCalendarRepository : IRepositoryBase<CourseCalendar>
    {
        Task<IEnumerable<CourseCalendar>> GetAllCourseCalendarAsync(int courseId, bool trackChanges);
        Task<CourseCalendar> GetOneCourseCalendarByIdAsync(int courseId, byte dayId, bool trackChanges);
        Task<bool> CourseCalenderExistWithAny(int courseId,byte dayId);
        Task CreateOneCourseCalendarAsync(CourseCalendar courseCalendar);
        void UpdateOneCourseCalendar(CourseCalendar courseCalendar);
        void DeleteOneCourseCalendar(CourseCalendar courseCalendar);
    }
}
