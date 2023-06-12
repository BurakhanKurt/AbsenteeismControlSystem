using AutoMapper;
using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class CourseCalenderManager : ICourseCalendarService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CourseCalenderManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager=manager;
            _mapper=mapper;
        }

        public async Task<IEnumerable<CourseCalendarDto>> GetAllCourseCalendarAsync(int courseId, bool trackChanges)
        {
            var courseCalendars = await 
                _manager.CourseCalendar
                .GetAllCourseCalendarAsync(courseId, trackChanges);
            var courseCalendarDtos = _mapper.Map<List<CourseCalendarDto>>(courseCalendars);
            // Todo Hata yonetimini unutma
            return courseCalendarDtos; 
        }

        public async Task<CourseCalendarDto> GetOneCourseCalendarAsync(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = await 
                _manager.CourseCalendar
                .GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);

            var courseCalendarDto = _mapper.Map<CourseCalendarDto>(courseCalendar);
            return courseCalendarDto;
        }
        public async Task UpdateOneCourseCalendarAsync(int courseId,
            byte dayId, CourseCalendarDto courseCalendarDto, bool trackChanges)
        {
            var entity = await _manager
                .CourseCalendar
                .GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);
            // Todo Hata yönetimi yapılacak
            
            entity = _mapper.Map(courseCalendarDto, entity);
            entity.CourseId = courseId;
            entity.DayId = dayId;
            entity.UpdateDate = DateTime.Now;

            _manager.CourseCalendar.UpdateOneCourseCalendar(entity);
            await _manager.SaveAsync();
        }

        public async Task DeleteOneCourseCalendarAsync(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = await _manager
                .CourseCalendar.
                GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);
            // Todo hata yönetimi yapılacak

            _manager.CourseCalendar.DeleteOneCourseCalendar(courseCalendar);
            await _manager.SaveAsync();
        }



    }
}
