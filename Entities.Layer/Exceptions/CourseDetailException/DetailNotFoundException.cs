using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.CourseDetailException
{
    public class DetailNotFoundException : NotFoundException
    {
        public DetailNotFoundException(int id) 
            : base($"The Course Detail with id : {id} could not found")
        {
        }
    }
}
