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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId);

            modelBuilder.Entity<Course>()
                .Property(c => c.Title)
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .HasMaxLength(1000);
        }
    }
}
