﻿using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.Params;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class CourseCalendarController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CourseCalendarController(IServiceManager manager)
        {
            _manager=manager;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCourseCalendarAsync([FromRoute(Name = "id")] int courseId)
        {
            var courseCalendarsDto = await _manager
                .CourseCalendarService
                .GetAllCourseCalendarAsync(courseId, false);
            return Ok(courseCalendarsDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetOneCourseCalendarAsync(
            [FromQuery] CourseCalendarParams calendarParams)
        {
            var calendar = await _manager
               .CourseCalendarService
               .GetOneCourseCalendarAsync(calendarParams.cId, calendarParams.dId, false);
            return Ok(calendar);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOneCourseCalendarAsync(
            [FromQuery] CourseCalendarParams calendarParams,
            [FromBody] CourseCalendarDto courseCalendarDto)
        {
            await _manager
                .CourseCalendarService
                .UpdateOneCourseCalendarAsync(
                    calendarParams.cId,
                    calendarParams.dId,
                    courseCalendarDto,
                    false
                 );
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOneCourseCalendarAsync(
            [FromQuery]CourseCalendarParams courseCalendarParams)
        {
            await _manager
                .CourseCalendarService
                .DeleteOneCourseCalendarAsync(
                    courseCalendarParams.cId,
                    courseCalendarParams.dId,
                    true
                );

            return NoContent();
        }
    }
}