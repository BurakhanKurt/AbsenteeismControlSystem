using AutoMapper;
using Entities.DTOs.CourseDtos;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Repositories.Abstracts;
using Service.Abstracts;

namespace Service.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
 
        public CourseManager(IRepositoryManager repositoryManager, IMapper _mapper)
        {
            _repositoryManager = repositoryManager;
            this._mapper = _mapper;
        }

        // Bir kursu asenkron olarak oluşturur
        public async Task<CourseCreateDto> CreateOneCourseAsync(int userId, CourseCreateDto courseCreateDto)
        {
            var course = _mapper.Map<Course>(courseCreateDto);
            course.UserId = userId;
            course.CreatedDate = DateTime.Now;
            course.CourseDetail.CreatedDate = DateTime.Now;
            await _repositoryManager.Course.CreateOneCourseAsync(course);
            await _repositoryManager.SaveAsync();
            var response = _mapper.Map<CourseCreateDto>(course);
            return response;
        }

        // Bir kursu asenkron olarak siler
        public async Task DeleteOneCourseAsync(int courseId, bool trackChanges)
        {
            var entity = await _repositoryManager.Course.GetOneCourseByIdAsync(courseId, trackChanges);
            _repositoryManager.Course.DeleteOneCourse(entity);
            await _repositoryManager.SaveAsync();
        }

        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        public async Task<IEnumerable<CourseDto>> GetAllCourseByUserAsync(
            PageListParameters pageListParameters, int userId, bool trackChanges)
        {
            var courses = await _repositoryManager
                .Course
                .GetAllCourseByUserAsync(pageListParameters,userId, trackChanges);

            var response = _mapper.Map<List<CourseDto>>(courses);
            return response;
        }

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        public async Task<IEnumerable<TodayCoursesDto>> GetAllUserCoursesByDayAndTimeAsync(int userId, byte dayId, bool trackChanges)
        {
            var courses = await _repositoryManager.Course.GetAllUserCoursesByDayAndTimeAsync(userId, dayId, trackChanges);
            var response = _mapper.Map<List<TodayCoursesDto>>(courses);
            return response;
        }

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        public async Task<CourseDto> GetOneCourseByIdAsync(int courseId, bool trackChanges)
        {
            var course = await _repositoryManager.Course.GetOneCourseByIdAsync(courseId, trackChanges);
            var response = _mapper.Map<CourseDto>(course);
            return response;
        }

        // Günleri ile birlikte belirli bir kursu asenkron olarak getirir
        public async Task<Course> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges)
        {
            return await _repositoryManager.Course.GetOneCourseByIdWithDaysAsync(courseId, trackChanges);
        }

        // Detaylarıyla birlikte belirli bir kursu asenkron olarak getirir
        public async Task<Course> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges)
        {
            return await _repositoryManager.Course.GetOneCourseByIdWithDetailAsync(courseId, trackChanges);
        }

        // Bir kursu asenkron olarak günceller
        public async Task UpdateOneCourseAsync(CourseUpdateDto course,bool trackChanges)
        {
            int id = course.Id;
            var entity = await _repositoryManager.Course.GetOneCourseByIdAsync(id,trackChanges); 
            entity = _mapper.Map(course,entity);
            entity.UpdateDate= DateTime.Now;
            _repositoryManager.Course.UpdateOneCourse(entity);
            await _repositoryManager.SaveAsync();
        }
        public async Task<MetaData> MetaData(int userId,PageListParameters pageListParameters)
        {
            var count = await _repositoryManager.Course.CountAsync(u => u.UserId == userId);
            var pageSize = pageListParameters.PageSize;
            var pageNumber = pageListParameters.PageNumber;

            return new MetaData()
            {
                TotalCount = count,
                TotalPage = (int)Math.Ceiling(count/(double)pageSize),
                CurrentPage = pageNumber,
                PageSize = pageSize
            };
        }
    }
}

