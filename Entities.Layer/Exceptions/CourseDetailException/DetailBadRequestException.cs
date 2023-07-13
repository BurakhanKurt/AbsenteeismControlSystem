using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.CourseDetailException
{
    public class DetailBadRequestException : BadRequestException
    {
        // Todo Mesajı değiştir
        public DetailBadRequestException() 
            : base("Something went wrong for Course Detail")
        {

        }
    }
}
