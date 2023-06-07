using Entities.Layer.Models;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface ICourseDetailRepository : IRepositoryBase<CourseDetail>
    {
        void UpdateOneCourseDetail(CourseDetail courseDetail);
        Task<CourseDetail> GetOneCourseDetailByIdAsync(int courseDetailId, bool trackChanges);
    }
}
