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
        private readonly AuthorRepository authorRepository;

        public AuthorService(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return authorRepository.GetAllAuthors();
        }

        public Author GetById(int id)
        {
            return authorRepository.GetById(id);
        }

        public Author CreateAuthor(AuthorDTO author)
        {
            Author newAuthor = new Author
            {
                Name = author.Name
            };

            return authorRepository.CreateAuthor(newAuthor);
        }
    }
}
