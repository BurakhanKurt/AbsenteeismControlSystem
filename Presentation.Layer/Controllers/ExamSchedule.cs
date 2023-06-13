using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ExamSchedule : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ExamSchedule(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{user:int}")]
        public async Task<IActionResult> GetExamScheduleByUser([FromRoute(Name = "user")]int userId)
        {
            var details = await _serviceManager.CourseDetailService.GetExamScheduleByUser(userId, false);
            return Ok(details);
        }

    }
}
