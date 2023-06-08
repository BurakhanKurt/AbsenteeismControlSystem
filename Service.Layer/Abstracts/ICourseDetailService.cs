using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetailAsync(int courseDetailId,CourseDetailDto courseDetailDto,bool trackChanges);
        
    }
}
