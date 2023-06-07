using Entities.Layer.DTOs.CourseDetailDtos;
using Entities.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/coursedetails")]
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
    }
}
