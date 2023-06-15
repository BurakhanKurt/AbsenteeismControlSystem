using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]s")]
    public class ExamScheduleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ExamScheduleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetExamScheduleByUser()
        {
            var userId = _serviceManager.userId(HttpContext.User);
            var details = await _serviceManager
                .CourseDetailService 
                .GetExamScheduleByUser(userId, false);

            return Ok(details);
        }
    }
}
