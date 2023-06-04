using Entities.Layer.Models;
using Repositories.Layer.Abstract;

namespace Repositories.Layer.Concretes
{
    public class CourseCalendarRepository : RepositoryBase<CourseCalendar>, ICourseCalendarRepository
    {
        public CourseCalendarRepository(AppDbContext context) : base(context)
        {
        }

        public void DeleteOneCourseCalendar(CourseCalendar courseCalendar) => Delete(courseCalendar);

        public void UpdateOneCourseCalendar(CourseCalendar courseCalendar) => Update(courseCalendar);
    }
}
