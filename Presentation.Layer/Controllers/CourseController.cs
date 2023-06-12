using Entities.Layer.DTOs.CourseDtos.Response;
using Entities.Layer.Params;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class CourseController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CourseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("create/{user:int}")]
        public async Task<IActionResult> CreateOneCourseAsync([FromRoute(Name = "user")] int userId, [FromBody] CourseDto courseCreateDto)
        {
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

        [HttpGet("byuser/{user:int}")]
        public async Task<IActionResult> GetAllCourseByUserAsync([FromRoute(Name = "user")] int userId)
        {
            var courses = await _serviceManager.CourseServices.GetAllCourseByUserAsync(userId, false);
            return Ok(courses);
        }


        [HttpGet(Name = "GetAllUserCoursesByDayAndTimeAsync")]
        public async Task<IActionResult> GetAllUserCoursesByDayAndTimeAsync([FromQuery] CourseDayAndUserParams myParams)
        {
            var courses = await _serviceManager.CourseServices.GetAllUserCoursesByDayAndTimeAsync(myParams.usId, myParams.daId, false);
            return Ok(courses);
        }


    }
}
