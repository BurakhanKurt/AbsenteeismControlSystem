using Entities.Layer.Models;


namespace Repositories.Layer.Repositories.Abstract
{
    public interface ICourseDetailRepository : IRepositoryBase<CourseDetail>
    {
        void UpdateOneCourseDetail(CourseDetail courseDetail);
    }
}
