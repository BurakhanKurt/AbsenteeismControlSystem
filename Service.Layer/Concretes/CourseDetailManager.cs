using Entities.Layer.Models;
using Repositories.Layer.Repositories.Abstracts;
using Service.Layer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Layer.Concretes
{
    public class CourseDetailManager : ICourseDetailService
    {
        private readonly IRepositoryManager _manager;

        public CourseDetailManager(IRepositoryManager manager)
        {
            _manager=manager;
        }

        public async Task UpdateOneCourseDetail(int courseId, CourseDetail courseDetail, bool trackChanges)
        {
            var entity = await _manager.CourseDetail.GetOneCourseDetailByIdAsync(courseId, trackChanges);
            // Todo Hata yonetimi yapılacak

            // Todo AutoMapper Kullanılacak
            entity.UpdateDate = DateTime.Now;
            entity.Description = courseDetail.Description;
            entity.AbsenceLimit = courseDetail.AbsenceLimit;
            entity.ExamTime = courseDetail.ExamTime;
            entity.CurrentAbsence = courseDetail.CurrentAbsence;
            _manager.CourseDetail.UpdateOneCourseDetail(courseDetail);
            await _manager.SaveAsync();
        }
    }
}
