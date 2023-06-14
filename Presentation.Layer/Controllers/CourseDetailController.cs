using Entities.Layer.DTOs.CourseDetailDtos;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> UpdateOneCourseDetailAsync([FromRoute(Name = "id")]int id,
            [FromBody]CourseDetailDto courseDetailDto)
        {
            await _manager
                .CourseDetailService
                .UpdateOneCourseDetailAsync(id, courseDetailDto, false);
            return NoContent();
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCourseDetailAsync([FromRoute(Name = "id")]int id)
        {
            var courseDetailDto = await _manager
                .CourseDetailService
                .GetOneCourseDetailAsync(id, false);
            return Ok(courseDetailDto);
        }
    }
}
