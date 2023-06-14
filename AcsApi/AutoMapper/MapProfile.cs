﻿using AutoMapper;
using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.DTOs.CourseDtos;
using Entities.Layer.DTOs.SyllabusDtos;

using Entities.Layer.Models;
using Entities.Layer.DTOs.CourseDtos;
using Entities.Layer.DTOs;
using Entities.Layer.DTOs.UserDtos;

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
