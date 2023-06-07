using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICourseService courseService;
        private readonly ICourseDetailService courseDetailService;
        private readonly ICourseCalendarService courseCalendarService;
        private readonly ISyllabusService syllebusService;

        public ServiceManager(ICourseService courseService,
            ICourseDetailService courseDetailService,
            ICourseCalendarService courseCalendarService,
            ISyllabusService syllebusService)
        {
            this.courseService=courseService;
            this.courseDetailService=courseDetailService;
            this.courseCalendarService=courseCalendarService;
            this.syllebusService=syllebusService;
        }

        public ICourseService CourseServices => courseService;

        public ICourseDetailService CourseDetailService => courseDetailService;

        public ICourseCalendarService CourseCalendarService => courseCalendarService;

        public ISyllabusService SyllebusService => syllebusService;
    }
}
