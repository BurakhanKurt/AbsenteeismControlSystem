using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions.SyllabusException
{
    public class SyllabusNotFoundException : BadRequestException
    {
        public SyllabusNotFoundException(int id)
            : base($"The Syllabus could not found for userId : {id}")
        { }
    }
}
