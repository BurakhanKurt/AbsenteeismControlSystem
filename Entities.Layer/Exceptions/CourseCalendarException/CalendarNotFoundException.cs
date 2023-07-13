using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.CourseCalendarException
{
    public class CalendarNotFoundException : NotFoundException
    {
        public CalendarNotFoundException(int courseId,int dayId)
            : base($"The Course Calendar with courseId : {courseId} and dayId : {dayId} could not found")
        { }
    }
}
