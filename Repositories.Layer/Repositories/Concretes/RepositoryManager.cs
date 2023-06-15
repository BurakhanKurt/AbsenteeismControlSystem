
using Repositories.Repositories.Abstracts;
using Repositories.UnıtOfWorks.Abstract;

namespace Repositories.Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ICourseRepository courseRepository;
        private readonly ICourseDetailRepository courseDetailRepository;
        private readonly ICourseCalendarRepository courseCalendarRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISyllabusRepository syllabusRepository;

        public RepositoryManager(
            ICourseRepository courseRepository,
            ICourseDetailRepository courseDetailRepository,
            ICourseCalendarRepository courseCalendarRepository,
            IUnitOfWork unitOfWork,
            ISyllabusRepository syllabusRepository)
        {
            this.courseRepository = courseRepository;
            this.courseDetailRepository = courseDetailRepository;
            this.courseCalendarRepository = courseCalendarRepository;
            this.syllabusRepository=syllabusRepository;
            _unitOfWork = unitOfWork;
        }
        public ICourseRepository Course => courseRepository;
        public ICourseDetailRepository CourseDetail => courseDetailRepository;
        public ICourseCalendarRepository CourseCalendar => courseCalendarRepository;
        public ISyllabusRepository Syllabus => syllabusRepository;

        public async Task SaveAsync()
        {
            await _unitOfWork.CommitAsync();
        }

        public void Save()
        {
             _unitOfWork.Commit();
        }
    }
}
