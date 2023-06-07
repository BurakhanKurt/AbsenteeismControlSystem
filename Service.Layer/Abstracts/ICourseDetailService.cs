using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseDetailService 
    {
        Task UpdateOneCourseDetail(int courseDetailId,CourseDetail courseDetail,bool trackChanges);       
    }
}
