using Entities.Layer.Models;
using System.Linq.Expressions;

namespace Repositories.Layer.Abstract
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        //Kullanıcının Tum derslerini getiren method
        Task<IEnumerable<Course>> GetAllCourseByUserAsync(int userId,bool trackChanges);
        //Kullanıcının tum derslerini güne bağlı getiren method
        Task<IEnumerable<Course>> GetAllUserCoursesByDayAsync(int userId,int dayId,bool trackChanges);
        //Kullanıcının bir dersinin detayını ve saatini getiren method
        Task<Course?> GetOneCourseByIdWithDetailAsync(int userId,int courseId,bool trackChanges);
        //Kullanıcının bir dersinin hangi gunlerde oldugunu getiren method
        Task<Course?> GetOneCourseByIdWithDaysAsync(int userId,int courseId,bool trackChanges);
        //Kullanıcının bir dersini getiren method
        Task<Course?> GetOneCourseByIdAsync(int userId,int courseId,bool trackChanges);
        void CreateOneCourse(Course course);
        void UpdateOneCourse(Course course);
        void DeleteOneCourse(Course course);
    }
}
