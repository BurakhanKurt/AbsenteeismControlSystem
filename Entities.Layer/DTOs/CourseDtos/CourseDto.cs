using Entities.Layer.DTOs.CourseDetailDtos;


namespace Entities.Layer.DTOs.CourseDtos.Response
{
    public record CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public CourseDetailDto  CourseDetail { get; set; }
    }
}
