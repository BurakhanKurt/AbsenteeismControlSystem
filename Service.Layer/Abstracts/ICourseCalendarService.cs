using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseCalendarService
    {
        Task UpdateOneCourseCalendarAsync(int courseId,int dayId,CourseCalendar courseCalendar,bool trackChanges);
        Task DeleteOneCourseCalendar(int courseId, int dayId,bool trackChanges);
    }
}
