using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class CourseDetailRepository : RepositoryBase<CourseDetail>, ICourseDetailRepository
    {
        public CourseDetailRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<CourseDetail> GetOneCourseDetailByIdAsync(int courseId, bool trackChanges)
        {
            var courseDetail = await 
                GetByCondition(c => c.CourseId == courseId,trackChanges)
                .SingleOrDefaultAsync();
            return courseDetail;
        }

        public void UpdateOneCourseDetail(CourseDetail courseDetail) => Update(courseDetail);
    }
}
