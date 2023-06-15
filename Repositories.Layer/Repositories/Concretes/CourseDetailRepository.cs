
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstracts;

namespace Repositories.Repositories.Concretes
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

        public async Task<IEnumerable<CourseDetail>> GetExamScheduleByUserAsync (int userId,bool trackChanges)
        {
            var userCourses = await GetByCondition(cd=>cd.Course.UserId == userId && cd.ExamTime != null, trackChanges)
                .OrderBy(cd=> cd.ExamTime)
                .Include(cd => cd.Course)
                .ToListAsync();
            return userCourses;
        }

        public void UpdateOneCourseDetail(CourseDetail courseDetail) => Update(courseDetail);
    }
}
