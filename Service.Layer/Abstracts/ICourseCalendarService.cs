using Entities.DTOs.CourseCalendarDtos;
using Entities.Models;

namespace Service.Abstracts
{
    public interface ICourseCalendarService
    {
        Task<IEnumerable<CourseCalendarDto>> GetAllCourseCalendarAsync(int courseId,bool trackChanges);
        Task<CourseCalendarDto> GetOneCourseCalendarAsync(int courseId,byte dayId,bool trackChanges);
        Task<CourseCalendar> CreateOneCourseCalendarAsync(int courseId, byte dayId,CourseCalendarDto courseCalendarDto);
        Task UpdateOneCourseCalendarAsync(int courseId,byte dayId,CourseCalendarDto courseCalendarDto,bool trackChanges);
        Task DeleteOneCourseCalendarAsync(int courseId, byte dayId,bool trackChanges);
    }
}
