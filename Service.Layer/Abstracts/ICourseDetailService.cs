using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetailAsync(int courseDetailId,CourseDetail courseDetail,bool trackChanges);       
    }
}
