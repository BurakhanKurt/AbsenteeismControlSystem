
using Entities.DTOs.CourseDetailDtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]s")]
    public class CourseDetailController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CourseDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPut("{id:int}")] 
        public async Task<IActionResult> UpdateOneCourseDetailAsync([FromRoute(Name = "id")]int id,
            [FromBody]CourseDetailDto courseDetailDto)
        {
            await _serviceManager
                .CourseDetailService
                .UpdateOneCourseDetailAsync(id, courseDetailDto, false);

            return NoContent();
        }

        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCourseDetailAsync([FromRoute(Name = "id")]int id)
        {
            var courseDetailDto = await _serviceManager
                .CourseDetailService
                .GetOneCourseDetailAsync(id, false);
            return Ok(courseDetailDto);
        }
    }
}
