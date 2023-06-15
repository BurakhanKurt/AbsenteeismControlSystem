
using System.Security.Claims;

namespace Service.Abstracts
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
