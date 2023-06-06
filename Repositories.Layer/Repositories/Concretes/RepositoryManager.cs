using Repositories.Layer.Repositories.Abstracts;
using Repositories.Layer.UnıtOfWorks.Abstract;

namespace Repositories.Layer.Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ICourseRepository courseRepository;
        private readonly ICourseDetailRepository courseDetailRepository;
        private readonly ICourseCalendarRepository courseCalendarRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryManager(
            ICourseRepository courseRepository,
            ICourseDetailRepository courseDetailRepository,
            ICourseCalendarRepository courseCalendarRepository,
            IUnitOfWork unitOfWork)
        {
            this.courseRepository = courseRepository;
            this.courseDetailRepository = courseDetailRepository;
            this.courseCalendarRepository = courseCalendarRepository;
            _unitOfWork = unitOfWork;
        }
        public ICourseRepository Course => courseRepository;
        public ICourseDetailRepository CourseDetail => courseDetailRepository;
        public ICourseCalendarRepository CourseCalendar => courseCalendarRepository;

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
