using AutoMapper;
using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class CourseDetailManager : ICourseDetailService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CourseDetailManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager=manager;
            _mapper=mapper;
        }

        public async Task UpdateOneCourseDetailAsync(int courseId, CourseDetailDto courseDetailDto, bool trackChanges)
        {
            var entity = await _manager.CourseDetail.GetOneCourseDetailByIdAsync(courseId, trackChanges);
            // Todo Hata yonetimi yapılacak

            entity = _mapper.Map<CourseDetail>(courseDetailDto);
            entity.UpdateDate = DateTime.Now;  

            _manager.CourseDetail.UpdateOneCourseDetail(entity);
            await _manager.SaveAsync();
        }
    }
}
