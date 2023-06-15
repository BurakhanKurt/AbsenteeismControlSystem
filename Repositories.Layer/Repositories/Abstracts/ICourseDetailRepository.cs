
using Entities.Models;

namespace Repositories.Repositories.Abstracts
{
    public interface ICourseDetailRepository : IRepositoryBase<CourseDetail>
    {
        void UpdateOneCourseDetail(CourseDetail courseDetail);
        Task<CourseDetail> GetOneCourseDetailByIdAsync(int courseDetailId, bool trackChanges);
        Task<IEnumerable<CourseDetail>> GetExamScheduleByUserAsync(int userId, bool trackChanges);
    }
}
