using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YudemyAPI.Models;

namespace YudemyAPI.Context
{
    public class YudemyContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }

        public YudemyContext (DbContextOptions<YudemyContext> options)
            : base(options)
        { }
    }
}
