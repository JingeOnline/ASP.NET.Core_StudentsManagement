using ASP.NET.Core_StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.Services
{
    public class SqlServerStudentService : IStudentService
    {
        private readonly AppDbContext _context;
        public SqlServerStudentService(AppDbContext context)
        {
            _context = context;
        }


        public StudentModel Add(StudentModel studentModel)
        {
            _context.Students.Add(studentModel);
            _context.SaveChanges();
            return studentModel;
        }

        public StudentModel Delete(int id)
        {
            StudentModel student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public StudentModel GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public IEnumerable<StudentModel> GetStudents()
        {
            return _context.Students;
        }

        public StudentModel Update(StudentModel studentModel)
        {
            var student = _context.Students.Attach(studentModel);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return studentModel;
        }
    }
}
