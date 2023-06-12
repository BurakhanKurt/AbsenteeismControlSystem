using AutoMapper;
using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.DTOs.CourseDtos;
using Entities.Layer.DTOs.SyllabusDtos;

using Entities.Layer.Models;
using Entities.Layer.DTOs.CourseDtos;

namespace AcsApi.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CourseDetailDto, CourseDetail>().ReverseMap();
            CreateMap<CourseCalendarDto, CourseCalendar>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<CourseCalendar, CourseCalendarDto>();
            CreateMap<Day, SyllabusDto>();
            CreateMap<CourseCreateDto, Course>().ReverseMap();
            CreateMap<CourseCalendar, CourseCalendarForSyllabusDto>();
            CreateMap<TodayCoursesDto, Course>().ReverseMap();
        }
    }
}
