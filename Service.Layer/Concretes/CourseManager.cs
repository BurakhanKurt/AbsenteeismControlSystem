using AutoMapper;
using Entities.Layer.DTOs.CourseDtos;

using Entities.Layer.DTOs.CourseDtos.Response;
using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
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
        public async Task<CourseDto> CreateOneCourseAsync(int userId, CourseDto courseCreateDto)
        {
            var course = _mapper.Map<Course>(courseCreateDto);
            course.UserId = userId;
            course.CreatedDate = DateTime.Now;
            course.CourseDetail.CreatedDate = DateTime.Now;
            await _repositoryManager.Course.CreateOneCourseAsync(course);
            await _repositoryManager.SaveAsync();
            var response = _mapper.Map<CourseDto>(course);
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
        public async Task<IEnumerable<CourseDto>> GetAllCourseByUserAsync(int userId, bool trackChanges)
        {
            var courses = await _repositoryManager.Course.GetAllCourseByUserAsync(userId, trackChanges);
            var response = _mapper.Map<List<CourseDto>>(courses);
            return response;
        }

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        public async Task<IEnumerable<Course>> GetAllUserCoursesByDayAndTimeAsync(int userId, int dayId, bool trackChanges)
        {
            var courses = await _repositoryManager.Course.GetAllUserCoursesByDayAndTimeAsync(userId, dayId, trackChanges);
            return courses;
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
        public async Task<Course> UpdateOneCourseAsync(int courseId, Course course, bool trackChanges)
        {
            var entity = await _repositoryManager.Course.GetOneCourseByIdAsync(courseId, trackChanges);
            _repositoryManager.Course.UpdateOneCourse(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}

