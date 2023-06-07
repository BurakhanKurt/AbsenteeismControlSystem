using AutoMapper;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;

namespace AcsApi.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CourseDetailDto, CourseDetail>();

    }
}
}
