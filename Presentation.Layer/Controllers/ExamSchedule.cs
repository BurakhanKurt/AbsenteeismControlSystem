using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;

namespace Presentation.Controllers
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
