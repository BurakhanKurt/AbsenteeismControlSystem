
using Entities.DTOs.CourseDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]s")]
    public class CourseController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CourseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        
        [HttpPost("create")]
        public async Task<IActionResult> CreateOneCourseAsync([FromBody] CourseCreateDto courseCreateDto)
        {
            var userId = TokenHelper.GetUserIdFromToken(HttpContext.User);
            var course = await _serviceManager.CourseServices.CreateOneCourseAsync(userId, courseCreateDto);
            return StatusCode(201, course);
        }

        [HttpGet("one/{id:int}")]
        public async Task<IActionResult> GetOneCourse([FromRoute(Name = "id")] int courseId)
        {
            var course = await _serviceManager.CourseServices.GetOneCourseByIdAsync(courseId, false);
            return StatusCode(200, course);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneCourseById([FromRoute(Name = "id")] int courseId)
        {
            await _serviceManager.CourseServices.DeleteOneCourseAsync(courseId, false);

            return NoContent();
        }

        [HttpGet("byuser")]
        public async Task<IActionResult> GetAllCourseByUserAsync()
        {
            var userId = TokenHelper.GetUserIdFromToken(HttpContext.User);
            var courses = await _serviceManager.CourseServices
                .GetAllCourseByUserAsync(userId, false);

            return Ok(courses);
        }

        [HttpGet("today")]
        public async Task<IActionResult> GetAllUserCoursesByDayAndTimeAsync([FromRoute] byte dayId)
        {
            var userId = TokenHelper.GetUserIdFromToken(HttpContext.User);
            var courses = await _serviceManager.CourseServices
                .GetAllUserCoursesByDayAndTimeAsync(userId, dayId, false);
            return Ok(courses);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse([FromBody] CourseUpdateDto course)
        {
            await _serviceManager.CourseServices.UpdateOneCourseAsync(course,false);
            return NoContent();
        }
    }
}
