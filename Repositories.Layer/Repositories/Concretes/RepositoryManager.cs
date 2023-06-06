using Repositories.Layer.Repositories.Abstracts;

namespace Repositories.Layer.Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly ICourseRepository courseRepository;
        private readonly ICourseDetailRepository courseDetailRepository;
        private readonly ICourseCalendarRepository courseCalendarRepository;
        private readonly ISyllabusRepository syllabusRepository;

        public RepositoryManager(AppDbContext context,
            ICourseRepository courseRepository,
            ICourseDetailRepository courseDetailRepository,
            ICourseCalendarRepository courseCalendarRepository,
            ISyllabusRepository syllabusRepository)
        {
            _context = context;
            this.courseRepository = courseRepository;
            this.courseDetailRepository = courseDetailRepository;
            this.courseCalendarRepository = courseCalendarRepository;
            this.syllabusRepository=syllabusRepository;
        }

        public ICourseRepository Course => courseRepository;
        public ICourseDetailRepository CourseDetail => courseDetailRepository;
        public ICourseCalendarRepository CourseCalendar => courseCalendarRepository;

        public ISyllabusRepository Syllabus => syllabusRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
