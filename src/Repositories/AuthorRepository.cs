using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;
using YudemyAPI.Models.DTO;

namespace YudemyAPI.Repositories
{
    public class AuthorRepository
    {
        private readonly YudemyContext _context;

        public AuthorRepository(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Author> GetAll()
        {
            var result = _context.Authors.ToList();
            return result;
        }

        public Author GetById(int id)
        {
            var result = _context.Authors.Find(id);
            return result;
        }

        public Author Create(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return author;
        }
    }
}
