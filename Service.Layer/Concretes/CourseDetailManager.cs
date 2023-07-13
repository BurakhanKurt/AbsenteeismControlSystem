using AutoMapper;
using Entities.DTOs;
using Entities.DTOs.CourseDetailDtos;
using Entities.Exceptions.CourseDetailException;
using Entities.Models;
using Repositories.Repositories.Abstracts;
using Service.Abstracts;

namespace Service.Concretes
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

        public async Task<CourseDetailDto> GetOneCourseDetailAsync(int courseId, bool trackChanges)
        {
            var courseDetail = await 
                GetOneCourseDetailByIdCheckExistAsync(courseId, trackChanges);

            var courseDetailDto = _mapper.Map<CourseDetailDto>(courseDetail);

            return courseDetailDto;
        }

        public async Task UpdateOneCourseDetailAsync(int courseId, CourseDetailDto courseDetailDto, bool trackChanges)
        {
            if(courseDetailDto == null)
                throw new DetailBadRequestException();

            var entity = await 
                GetOneCourseDetailByIdCheckExistAsync(courseId, trackChanges);

            entity = _mapper.Map(courseDetailDto,entity);
            entity.CourseId = courseId;
            entity.UpdateDate = DateTime.Now;  

            _manager.CourseDetail.UpdateOneCourseDetail(entity);

            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<ExamScheduleDto>> GetExamScheduleByUser(int userId, bool trackChanges)
        {
            var details = await _manager.CourseDetail.GetExamScheduleByUserAsync(userId,trackChanges);
            var response = _mapper.Map<List<ExamScheduleDto>>(details);
            
            return response;
        }

        private async Task<CourseDetail> GetOneCourseDetailByIdCheckExistAsync(int courseId,bool trackChanges)
        {
            var entity = await _manager
                .CourseDetail
                .GetOneCourseDetailByIdAsync(courseId, trackChanges);

            if (entity == null)
                throw new DetailNotFoundException(courseId);

            return entity;
        }
    }
}
