using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CourseManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        // Bir kursu asenkron olarak oluşturur
        public async Task<Course> CreateOneCourseAsync(Course course)
        {
            course.CreatedDate = DateTime.Now;
            await _repositoryManager.Course.CreateOneCourseAsync(course);
            await _repositoryManager.SaveAsync();
            return course;
        }

        // Bir kursu asenkron olarak siler
        public async Task DeleteOneCourseAsync(int courseId, bool trackChanges)
        {
            var entity = await _repositoryManager.Course.GetOneCourseByIdAsync(courseId, trackChanges);
            _repositoryManager.Course.DeleteOneCourse(entity);
            await _repositoryManager.SaveAsync();
        }

        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        public async Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges)
        {
            var courses = await _repositoryManager.Course.GetAllCourseByUserAsync(userId, trackChanges);
            return courses;
        }

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        public async Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId, int dayId, bool trackChanges)
        {
            var courses = await _repositoryManager.Course.GetAllUserCoursesByDayAsync(userId, dayId, trackChanges);
            return courses;
        }

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        public async Task<Course> GetOneCourseByIdAsync(int courseId, bool trackChanges)
        {
            return await _repositoryManager.Course.GetOneCourseByIdAsync(courseId, trackChanges);
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

