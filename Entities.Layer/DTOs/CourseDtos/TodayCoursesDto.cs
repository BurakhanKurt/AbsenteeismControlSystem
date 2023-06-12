using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.DTOs.CourseDetailDtos;

namespace Entities.Layer.DTOs.CourseDtos
{
    public record TodayCoursesDto : CourseDto
    {

        public CourseDetailDto CourseDetail { get; set; } 
        public List<CourseCalendarDto> CourseCalendars { get; set; }
      

    }
}
