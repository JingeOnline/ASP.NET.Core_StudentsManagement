using ASP.NET.Core_StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.Services
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetStudents();
        StudentModel GetStudentById(int id);
        StudentModel Add(StudentModel studentModel);
        StudentModel Update(StudentModel studentModel);
        StudentModel Delete(int id);
    }
}
