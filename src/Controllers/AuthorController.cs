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
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly AuthorService authorService;

        public AuthorController(ILogger<AuthorController> logger, AuthorService authorService)
        {
            _logger = logger;
            this.authorService = authorService;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            _logger.LogInformation("Executing api/author -> Get All");
            return authorService.GetAll();
        }

        [HttpGet("{id}", Name = "GetAuthorById")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Executing api/author/id -> Get By ID " + id.ToString());
            var result = authorService.GetById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody]AuthorDTO author)
        {
            _logger.LogInformation("Executing api/author -> Post");
            var result = authorService.Create(author);

            return CreatedAtRoute("GetAuthorById", new { id = result.Id.ToString() }, result);
        }
    }
}
