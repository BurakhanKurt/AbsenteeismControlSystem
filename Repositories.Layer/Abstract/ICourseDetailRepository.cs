using Entities.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Layer.Abstract
{
    public interface ICourseDetailRepository: IRepositoryBase<CourseDetail>
    {
        void UpdateOneCourseDetail(CourseDetail courseDetail);
    }
}
