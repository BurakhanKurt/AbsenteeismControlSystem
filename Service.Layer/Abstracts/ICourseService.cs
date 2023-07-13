using Entities.DTOs.CourseDtos;

using Entities.Models;
using Entities.RequestFeatures;

namespace Service.Abstracts
{   
    public interface ICourseService
    {
        // Bir kursu asenkron olarak oluşturur
        Task<CourseCreateDto> CreateOneCourseAsync(int userId, CourseCreateDto courseCreateDto);

        // Bir kursu asenkron olarak günceller
        Task UpdateOneCourseAsync(CourseUpdateDto course, bool trackChanges);

        // Bir kursu asenkron olarak siler
        Task DeleteOneCourseAsync(int id, bool trackChanges);

        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        Task<IEnumerable<CourseDto>> GetAllCourseByUserAsync(
            PageListParameters pageListParameters,int userId, bool trackChanges);

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        Task<IEnumerable<TodayCoursesDto>> GetAllUserCoursesByDayAndTimeAsync(int userId, byte dayId, bool trackChanges);

        // Detaylarıyla birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges);

        // Günleri ile birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges);

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        Task<CourseDto> GetOneCourseByIdAsync(int courseId, bool trackChanges);
        Task<MetaData> MetaData(int userId, PageListParameters pageListParameters);
    }
}

