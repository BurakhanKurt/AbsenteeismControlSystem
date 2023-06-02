using Entities.Layer.Models;

namespace Repositories.Layer.Abstract
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        Task<IEnumerable<Course>> GetAllCourseByUser(int id,bool trackChanges);
        Task<IEnumerable<Course>> GetAllCourseByUser(int id,bool trackChanges);
        Task<Course> GetOneCourseById(int courseId,bool trackChanges);
        Task<Course> GetOneCourseByIdWithDetails(int courseId,bool trackChanges);
        Task CreateOneCourse(Course course);
        Task UpdateOneCourse(Course course);
        Task DeleteOneCourse(Course course);
    }
}
