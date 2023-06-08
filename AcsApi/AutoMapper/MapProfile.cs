using AutoMapper;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.DTOs.CourseDtos.Response;
using Entities.Layer.Models;

namespace AcsApi.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CourseDetailDto, CourseDetail>().ReverseMap();
            CreateMap<CourseDto, Course>().ReverseMap();
            CreateMap<List<Course>,CourseDto>().ReverseMap();
          
        }
    }
}
