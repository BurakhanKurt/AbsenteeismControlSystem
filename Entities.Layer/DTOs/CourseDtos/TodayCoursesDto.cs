
using Entities.DTOs.CourseCalendarDtos;
using Entities.DTOs.CourseDetailDtos;

namespace Entities.DTOs.CourseDtos
{
    public record TodayCoursesDto : CourseDto
    {
        public CourseDetailDto CourseDetail { get; set; } 
        public List<CourseCalendarDto> CourseCalendars { get; set; }

    }
}
