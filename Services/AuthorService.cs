﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;

namespace YudemyAPI.Services
{
    public class AuthorService
    {
        private readonly YudemyContext _context;

        public AuthorService(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var result = _context.Authors.ToList();
            return result;
        }

        public Author GetById(int id)
        {
            var result = _context.Authors.Where(x => x.Id == id).First();
            return result;
        }

        public Author CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return author;
        }
    }
}