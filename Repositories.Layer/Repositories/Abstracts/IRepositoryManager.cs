namespace Repositories.Layer.Repositories.Abstract
{
    public interface IRepositoryManager
    {
        ICourseRepository Course { get; }
        ICourseDetailRepository CourseDetail { get; }
        ICourseCalendarRepository CourseCalendar { get; }
        Task SaveAsync();
    }
}
