using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class CourseCalendarRepository : RepositoryBase<CourseCalendar>, ICourseCalendarRepository
    {
        public CourseCalendarRepository(AppDbContext context) : base(context)
        {
        }
        public void DeleteOneCourseCalendar(CourseCalendar courseCalendar) => Delete(courseCalendar);

        public async Task<CourseCalendar> GetOneCourseCalendarByIdAsync(int courseId, int dayId, bool trackChanges)
        {
            var courseCalendar = await 
                GetByCondition(x => x.CourseId == courseId && x.DayId == dayId,trackChanges)
                .SingleOrDefaultAsync();
            return courseCalendar;
        }

        public void UpdateOneCourseCalendar(CourseCalendar courseCalendar) => Update(courseCalendar);
    }
}