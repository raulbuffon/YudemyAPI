using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Context;
using YudemyAPI.Models;

namespace YudemyAPI.Repositories
{
    public class SectionRepository
    {
        private readonly YudemyContext _context;

        public SectionRepository(YudemyContext yudemyContext)
        {
            this._context = yudemyContext;
        }

        public IEnumerable<Section> GetAll()
        {
            var result = _context.Sections.ToList();
            return result;
        }

        public Section GetById(int id)
        {
            var result = _context.Sections.Find(id);
            return result;
        }

        public Section Create(Section section)
        {
            _context.Sections.Add(section);
            _context.SaveChanges();

            return section;
        }

        public Section Delete(Section section)
        {
            _context.Sections.Remove(section);
            _context.SaveChanges();

            return section;
        }

        public Section DeleteById(int id)
        {
            var section = _context.Sections.Find(id);

            _context.Sections.Remove(section);
            _context.SaveChanges();

            return section;
        }
    }
}
