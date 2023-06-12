using Entities.Layer.DTOs.CourseDetailDtos;


namespace Entities.Layer.DTOs.CourseDtos
{
    public record CourseDto : BaseDto
    {
        public string CourseName { get; set; }
        
    }
}
