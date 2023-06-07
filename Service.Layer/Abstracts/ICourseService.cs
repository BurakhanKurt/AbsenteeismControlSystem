using Entities.Layer.Models;

namespace Service.Layer.Abstracts
{
    public interface ICourseService
    {
        // Bir kursu asenkron olarak oluşturur
        Task<Course> CreateOneCourseAsync(Course course);

        // Bir kursu asenkron olarak günceller
        Task<Course> UpdateOneCourseAsync(int courseId, Course course, bool trackChanges);

        // Bir kursu asenkron olarak siler
        Task DeleteOneCourseAsync(int id, bool trackChanges);

        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges);

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları asenkron olarak getirir
        Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId, int dayId, bool trackChanges);

        // Detaylarıyla birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges);

        // Günleri ile birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges);

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        Task<Course> GetOneCourseByIdAsync(int courseId, bool trackChanges);
    }
}

