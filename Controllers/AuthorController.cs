using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Models;
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
            return authorService.GetAllAuthors();
        }

        [HttpGet("{id}", Name = "GetAuthorById")]
        public IActionResult GetById(int id)
        {
            var result = authorService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Author author)
        {
            authorService.CreateAuthor(author);

            return CreatedAtRoute("GetAuthorById", new { id = author.Id.ToString() }, author);
        }
    }
}
