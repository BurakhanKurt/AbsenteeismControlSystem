using Entities.Layer.DTOs.CourseDetailDtos;

namespace Service.Layer.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetailAsync(int courseDetailId,CourseDetailDto courseDetailDto,bool trackChanges);   
        Task<CourseDetailDto> GetOneCourseDetailAsync(int courseDetailId,bool trackChanges);   
    }
}
