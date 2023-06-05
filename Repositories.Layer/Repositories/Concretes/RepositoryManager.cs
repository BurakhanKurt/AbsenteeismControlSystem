using Repositories.Layer.Repositories.Abstract;

namespace Repositories.Layer.Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly ICourseRepository courseRepository;
        private readonly ICourseDetailRepository courseDetailRepository;
        private readonly ICourseCalendarRepository courseCalendarRepository;

        public RepositoryManager(AppDbContext context,
            ICourseRepository courseRepository,
            ICourseDetailRepository courseDetailRepository,
            ICourseCalendarRepository courseCalendarRepository)
        {
            _context = context;
            this.courseRepository = courseRepository;
            this.courseDetailRepository = courseDetailRepository;
            this.courseCalendarRepository = courseCalendarRepository;
        }

        public ICourseRepository Course => courseRepository;

        public ICourseDetailRepository CourseDetail => courseDetailRepository;

        public ICourseCalendarRepository CourseCalendar => courseCalendarRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
