using ASP.NET.Core_StudentsManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<StudentModel> Students{get;set;}

        //为数据库添加初始数据
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().HasData(
                new LocalStudentService().GetStudents()
                );
        }
    }
}
