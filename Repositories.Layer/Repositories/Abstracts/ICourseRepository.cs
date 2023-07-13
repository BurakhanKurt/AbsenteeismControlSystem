
using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Repositories.Abstracts
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        // Belirli bir kullanıcının tüm kurslarını asenkron olarak getirir
        Task<IEnumerable<Course>> GetAllCourseByUserAsync(
            PageListParameters pageListParameters, int userId, bool trackChanges);

        // Belirli bir kullanıcının belirli bir günde aldığı tüm kursları saati ile asenkron olarak getirir
        Task<IEnumerable<Course>> GetAllUserCoursesByDayAndTimeAsync(int userId, byte dayId, bool trackChanges);

        // Detaylarıyla birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges);

        // Günleri ile birlikte belirli bir kursu asenkron olarak getirir
        Task<Course> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges);

        // Belirli bir kursu asenkron olarak kurs idsine göre getirir
        Task<Course> GetOneCourseByIdAsync(int courseId, bool trackChanges);

        // Bir kursu asenkron olarak oluşturur
        Task CreateOneCourseAsync(Course course);

        // Bir kursu senkron olarak oluşturur
        void CreateOneCourse(Course course);

        // Bir kursu günceller
        void UpdateOneCourse(Course course);

        // Bir kursu siler
        void DeleteOneCourse(Course course);
    }
}
