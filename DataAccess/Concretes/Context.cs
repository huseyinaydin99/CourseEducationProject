using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class Context : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Category)
            .HasForeignKey("CategoryId")
            .IsRequired();

        modelBuilder.Entity<Instructor>()
            .HasMany(e => e.Courses)
            .WithOne(e => e.Instructor)
            .HasForeignKey("InstructorId")
            .IsRequired();
    }
}