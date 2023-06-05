using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class CourseDetailRepository : RepositoryBase<CourseDetail>, ICourseDetailRepository
    {
        public CourseDetailRepository(AppDbContext context) : base(context)
        {
        }
        public void UpdateOneCourseDetail(CourseDetail courseDetail) => Update(courseDetail);
    }
}
