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
            modelBuilder.Entity<Author>()
                .Property(a => a.Name)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .HasMaxLength(1000);

            modelBuilder.Entity<Course>()
                .Property(c => c.Title)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Section>()
                .Property(s => s.Title)
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Courses)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Sections)
                .WithOne();

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses)
                .UsingEntity(j => j.ToTable("CourseStudent"));
        }
    }
}
