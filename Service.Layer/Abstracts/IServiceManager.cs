
namespace Service.Layer.Abstracts
{
    public interface IServiceManager
    {
        ICourseService CourseServices { get; }
        ICourseDetailService CourseDetailService { get; }
        ICourseCalendarService CourseCalendarService { get; }
        ISyllabusService SyllebusService { get; }
        IAuthenticationService AuthenticationService { get; }

    }
}
