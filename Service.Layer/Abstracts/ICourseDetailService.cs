using Entities.Layer.DTOs;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetailAsync(int courseDetailId,CourseDetailDto courseDetailDto,bool trackChanges);   
        Task<CourseDetailDto> GetOneCourseDetailAsync(int courseDetailId,bool trackChanges);
        Task<IEnumerable<ExamScheduleDto>> GetExamScheduleByUser(int userId, bool trackChanges);
    }
}
