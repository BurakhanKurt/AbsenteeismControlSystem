using Entities.Layer.Models;


namespace Repositories.Layer.Repositories.Abstract
{
    public interface ICourseCalendarRepository : IRepositoryBase<CourseCalendar>
    {
        void UpdateOneCourseCalendar(CourseCalendar courseCalendar);
        void DeleteOneCourseCalendar(CourseCalendar courseCalendar);
    }
}
