using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class CourseDetailController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public CourseDetailController(IServiceManager manager)
        {
            _manager=manager;
        }

        [HttpPut("{id:int}")] 
        public async Task<IActionResult> UpdateDetailAsync([FromRoute(Name = "id")]int id,
            [FromBody]CourseDetailDto courseDetailDto)
        {
            await _manager
                .CourseDetailService
                .UpdateOneCourseDetailAsync(id, courseDetailDto, false);
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCourseDetail([FromRoute(Name = "id")]int id)
        {
            var courseDetailDto = await _manager
                .CourseDetailService
                .GetOneCourseDetailAsync(id, false);
            return Ok(courseDetailDto);
        }
    }
}
