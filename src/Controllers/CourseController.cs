using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;
using YudemyAPI.Services;

namespace YudemyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly CourseService courseService;

        public CourseController(ILogger<CourseController> logger, CourseService courseService)
        {
            _logger = logger;
            this.courseService = courseService;
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            _logger.LogInformation("Executing api/course -> Get All");
            return courseService.GetAll();
        }

        [HttpGet("{id}", Name = "GetCourseById")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Executing api/course/id -> Get By ID " + id.ToString());
            var result = courseService.GetById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CourseRequest course)
        {
            _logger.LogInformation("Executing api/course -> Post");
            var result = courseService.Create(course);

            return CreatedAtRoute("GetCourseById", new { id = result.Id.ToString() }, result);
        }
    }
}
