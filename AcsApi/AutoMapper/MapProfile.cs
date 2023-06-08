using AutoMapper;
using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;

namespace AcsApi.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CourseDetailDto, CourseDetail>().ReverseMap();
            CreateMap<CourseCalendarDto, CourseCalendar>().ReverseMap();
            CreateMap<List<CourseCalendar>, CourseCalendarDto>();
        }
    }
}
