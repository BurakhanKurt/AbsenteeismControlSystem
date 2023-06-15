namespace Repositories.Repositories.Abstracts
{
    public interface IRepositoryManager
    {
        ICourseRepository Course { get; }
        ICourseDetailRepository CourseDetail { get; }
        ICourseCalendarRepository CourseCalendar { get; }
        ISyllabusRepository Syllabus { get; }
        Task SaveAsync();
        void Save();
    }
}
