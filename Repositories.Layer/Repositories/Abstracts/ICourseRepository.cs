using Entities.Layer.Models;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        //Kullanıcının Tum derslerini getiren method
        Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId, bool trackChanges);
        //Kullanıcının tum derslerini güne bağlı getiren method
        Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId, int dayId, bool trackChanges);
        //dersin detayını ve saatini getiren method
        Task<Course?> GetOneCourseByIdWithDetailAsync(int courseId, bool trackChanges);
        //dersin hangi gunlerde oldugunu getiren method
        Task<Course?> GetOneCourseByIdWithDaysAsync(int courseId, bool trackChanges);
        //bir dersi getiren method
        Task<Course?> GetOneCourseByIdAsync(int courseId, bool trackChanges);
        void CreateOneCourse(Course course);
        void UpdateOneCourse(Course course, bool trackChanges);
        void DeleteOneCourse(Course course, bool trackChanges);
    }
}
