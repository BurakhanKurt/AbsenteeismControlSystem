using Entities.Models;
using Service.Abstracts;
using System.Security.Claims;

namespace Service.Concretes
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICourseService courseService;
        private readonly ICourseDetailService courseDetailService;
        private readonly ICourseCalendarService courseCalendarService;
        private readonly ISyllabusService syllebusService;
        private readonly IAuthenticationService authenticationService;
        
        public ServiceManager(ICourseService courseService,
            ICourseDetailService courseDetailService,
            ICourseCalendarService courseCalendarService,
            ISyllabusService syllebusService,
            IAuthenticationService authenticationService
            )
        {
            this.courseService=courseService;
            this.courseDetailService=courseDetailService;
            this.courseCalendarService=courseCalendarService;
            this.syllebusService=syllebusService;
            this.authenticationService=authenticationService;
        }

        public ICourseService CourseServices => courseService;

        public ICourseDetailService CourseDetailService => courseDetailService;

        public ICourseCalendarService CourseCalendarService => courseCalendarService;

        public ISyllabusService SyllebusService => syllebusService;
        
        public IAuthenticationService AuthenticationService => authenticationService;

    }
}
