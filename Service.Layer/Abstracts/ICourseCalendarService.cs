using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseCalendarService
    {
        Task<IEnumerable<CourseCalendarDto>> GetAllCourseCalendarAsync(int courseId,bool trackChanges);
        Task<CourseCalendarDto> GetOneCourseCalendarAsync(int courseId,byte dayId,bool trackChanges);
        Task UpdateOneCourseCalendarAsync(int courseId,byte dayId,CourseCalendarDto courseCalendarDto,bool trackChanges);
        Task DeleteOneCourseCalendarAsync(int courseId, byte dayId,bool trackChanges);
    }
}
