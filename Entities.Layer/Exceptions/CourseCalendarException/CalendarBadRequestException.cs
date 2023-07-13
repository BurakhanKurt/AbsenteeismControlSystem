
namespace Entities.Exceptions.CourseCalendarException
{
    public class CalendarBadRequestException : BadRequestException
    {
        // Todo Mesajı düzelt
        public CalendarBadRequestException(int courseId,byte dayId)
            : base($"The courseId: {courseId} the dayId: {dayId} records already exist")
        { }
    }
}
