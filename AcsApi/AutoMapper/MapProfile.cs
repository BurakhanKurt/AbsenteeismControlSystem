using AutoMapper;
using Entities.DTOs.CourseCalendarDtos;
using Entities.DTOs.CourseDetailDtos;
using Entities.DTOs.CourseDtos;
using Entities.DTOs.SyllabusDtos;

using Entities.Models;
using Entities.DTOs;
using Entities.DTOs.UserDtos;

namespace AcsApi.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //------DETAIL-----//
            CreateMap<CourseDetailDto, CourseDetail>().ReverseMap();
            CreateMap<CourseDetail,ExamScheduleDto>().ReverseMap();

            //------CALENDAR-----//
            CreateMap<CourseCalendar, CourseCalendarDto>().ReverseMap();
            CreateMap<CourseCalendar, CourseCalendarForSyllabusDto>();

            //------DAY-----//
            CreateMap<Day, SyllabusDto>();
            
            //------COURSE-----//
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, TodayCoursesDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();

            //------USER------//
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
