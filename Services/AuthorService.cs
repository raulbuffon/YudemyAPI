using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;
using YudemyAPI.Repositories;

namespace YudemyAPI.Services
{
    public class AuthorService
    {
        private readonly ILogger<AuthorService> _logger;
        private readonly AuthorRepository authorRepository;

        public AuthorService(ILogger<AuthorService> logger, AuthorRepository authorRepository)
        {
            _logger = logger;
            this.authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return authorRepository.GetById(id);
        }

        public Author Create(AuthorDTO author)
        {
            Author newAuthor = new Author
            {
                Name = author.Name
            };

            return authorRepository.Create(newAuthor);
        }
    }
}
