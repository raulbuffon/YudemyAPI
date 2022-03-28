using Microsoft.AspNetCore.Http;
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
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly StudentService studentService;

        public StudentController(ILogger<StudentController> logger, StudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            _logger.LogInformation("Executing api/student -> Get All");
            return studentService.GetAll();
        }

        [HttpGet("{id}", Name = "GetStudentById")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Executing api/student/id -> Get By ID " + id.ToString());
            var result = studentService.GetById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] StudentRequest student)
        {
            _logger.LogInformation("Executing api/student -> Post");
            var result = studentService.Create(student);

            return CreatedAtRoute("GetStudentById", new { id = result.Id.ToString() }, result);
        }

        [HttpPost("buyCourse")]
        public IActionResult BuyCourse([FromBody] BuyCourseRequest buyCourseRequest)
        {
            var result = studentService.BuyCourse(buyCourseRequest);
            return Ok();
        }
    }
}
