using Entities.DTOs;
using Entities.DTOs.CourseDetailDtos;
using Entities.Models;

namespace Service.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetailAsync(int courseDetailId,CourseDetailDto courseDetailDto,bool trackChanges);   
        Task<CourseDetailDto> GetOneCourseDetailAsync(int courseDetailId,bool trackChanges);
        Task<IEnumerable<ExamScheduleDto>> GetExamScheduleByUser(int userId, bool trackChanges);
    }
}
