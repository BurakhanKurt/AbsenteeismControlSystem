using AutoMapper;
using Entities.DTOs.CourseCalendarDtos;
using Entities.Exceptions.CourseCalendarException;
using Entities.Models;
using Repositories.Repositories.Abstracts;
using Service.Abstracts;

namespace Service.Concretes
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
            
            return courseCalendarDtos; 
        }

        public async Task<CourseCalendarDto> GetOneCourseCalendarAsync(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = await 
                GetOneCourseCalendarByIdCheckExist(courseId, dayId, trackChanges);

            var courseCalendarDto = _mapper.Map<CourseCalendarDto>(courseCalendar);
            return courseCalendarDto;
        }
        public async Task UpdateOneCourseCalendarAsync(int courseId,
            byte dayId, CourseCalendarDto courseCalendarDto, bool trackChanges)
        {
            var entity = await
                GetOneCourseCalendarByIdCheckExist(courseId,dayId,trackChanges);
            
            entity = _mapper.Map(courseCalendarDto, entity);
            entity.CourseId = courseId;
            entity.DayId = dayId;
            entity.UpdateDate = DateTime.Now;

            _manager.CourseCalendar.UpdateOneCourseCalendar(entity);
            await _manager.SaveAsync();
        }

        public async Task DeleteOneCourseCalendarAsync(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = 
                await GetOneCourseCalendarByIdCheckExist(courseId, dayId, trackChanges);

            _manager.CourseCalendar.DeleteOneCourseCalendar(courseCalendar);

            await _manager.SaveAsync();
        }

        public async Task<CourseCalendar> CreateOneCourseCalendarAsync(int courseId,byte dayId,CourseCalendarDto courseCalendarDto)
        {
            var result = await _manager
                .CourseCalendar
                .CourseCalenderExistWithAny(courseId, dayId);

            if (result)
                throw new CalendarBadRequestException(courseId, dayId);

            var calendar = _mapper.Map<CourseCalendar>(courseCalendarDto);
            calendar.CourseId = courseId;
            calendar.DayId = dayId;
            calendar.CreatedDate = DateTime.Now;
            await _manager.CourseCalendar.CreateOneCourseCalendarAsync(calendar);
            await _manager.SaveAsync();

            return calendar;
        }

        private async Task<CourseCalendar> GetOneCourseCalendarByIdCheckExist(int courseId, byte dayId, bool trackChanges)
        {
            var courseCalendar = await
                _manager.CourseCalendar
                .GetOneCourseCalendarByIdAsync(courseId, dayId, trackChanges);
            
            if (courseCalendar == null)
                throw new CalendarNotFoundException(courseId,dayId);

            return courseCalendar;
        }
    }
}
