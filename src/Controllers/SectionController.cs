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
    public class SectionController : ControllerBase
    {
        private readonly ILogger<SectionController> _logger;
        private readonly SectionService sectionService;

        public SectionController(ILogger<SectionController> logger, SectionService sectionService)
        {
            _logger = logger;
            this.sectionService = sectionService;
        }

        [HttpGet]
        public IEnumerable<Section> Get()
        {
            _logger.LogInformation("Executing api/section -> Get All");
            return sectionService.GetAll();
        }

        [HttpGet("{id}", Name = "GetSectionById")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Executing api/section/id -> Get By ID " + id.ToString());
            var result = sectionService.GetById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SectionDTO section)
        {
            _logger.LogInformation("Executing api/course -> Post");
            var result = sectionService.Create(section);

            return CreatedAtRoute("GetSectionById", new { id = result.Id.ToString() }, result);
        }
    }
}
