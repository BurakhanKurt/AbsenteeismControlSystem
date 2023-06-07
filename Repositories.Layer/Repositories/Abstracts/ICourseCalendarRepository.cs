using Entities.Layer.Models;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface ICourseCalendarRepository : IRepositoryBase<CourseCalendar>
    {
        Task<CourseCalendar> GetOneCourseCalendarByIdAsync(int courseId, int dayId, bool trackChanges);
        void UpdateOneCourseCalendar(CourseCalendar courseCalendar);
        void DeleteOneCourseCalendar(CourseCalendar courseCalendar);
    }
}
