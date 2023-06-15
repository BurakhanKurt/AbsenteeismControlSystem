using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;

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
            var userId = TokenHelper.GetUserIdFromToken(HttpContext.User);
            var details = await _serviceManager
                .CourseDetailService 
                .GetExamScheduleByUser(userId, false);

            return Ok(details);
        }
    }
}
