using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstracts;

namespace Repositories.Repositories.Concretes
{ 
    public class CourseCalendarRepository : RepositoryBase<CourseCalendar>, ICourseCalendarRepository
    {
        public CourseCalendarRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<CourseCalendar>> GetAllCourseCalendarAsync(int courseId, bool trackChanges)
        {
            var courseCalendars = await 
                GetByCondition(c => c.CourseId == courseId,trackChanges).
                OrderBy(c => c.StartTime).
                ToListAsync();
            return courseCalendars;
        }

        public async Task<CourseCalendar> GetOneCourseCalendarByIdAsync(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = await 
                GetByCondition(x => x.CourseId == courseId && x.DayId == dayId,trackChanges)
                .SingleOrDefaultAsync();
            return courseCalendar;
        }
        public async Task<bool> CourseCalenderExistWithAny(int courseId, byte dayId)
        {
            var result = 
                await AnyAsync(cc => cc.CourseId == courseId &&  cc.DayId == dayId);

            return result;
        }

        public void DeleteOneCourseCalendar(CourseCalendar courseCalendar) => Delete(courseCalendar);

        public void UpdateOneCourseCalendar(CourseCalendar courseCalendar) => Update(courseCalendar);

        public async Task CreateOneCourseCalendarAsync(CourseCalendar courseCalendar) => 
            await CreateAsync(courseCalendar);

    }
}