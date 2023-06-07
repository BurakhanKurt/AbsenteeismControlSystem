using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Layer.Abstracts
{
    public interface IServiceManager
    {
        ICourseService CourseServices { get; }
        ICourseDetailService CourseDetailService { get; }
        ICourseCalendarService CourseCalendarService { get; }
        ISyllebusService SyllebusService { get; }

    }
}
