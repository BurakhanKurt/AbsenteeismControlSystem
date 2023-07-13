using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.SyllabusException
{
    public class SyllabusBadRequest : BadRequestException
    {
        // Todo Mesajı düzelt
        public SyllabusBadRequest()
            : base("Something went wrong for Syllabus")
        {

        }
    }
}
