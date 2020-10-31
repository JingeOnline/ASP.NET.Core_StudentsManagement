using ASP.NET.Core_StudentsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.Services
{
    public class LocalStudentService : IStudentService
    {
        private readonly List<StudentModel> _students;

        public LocalStudentService()
        {
            _students = new List<StudentModel>()
            {
                new StudentModel{Id=1,Name="李白",Email="libai@gmail.com",Age=20,Dynasty=DynastyEnum.唐, 
                    PhotoPath="1.jpg"},
                new StudentModel{Id=2,Name="白居易",Email="baijuyi@gmail.com",Age=33,Dynasty=DynastyEnum.唐,
                    PhotoPath="2.jpg"},
                new StudentModel{Id=3,Name="杜甫",Email="dufu@gmail.com",Age=45, Dynasty=DynastyEnum.唐,
                    PhotoPath="3.jpg"},
                new StudentModel{Id=4,Name="王维",Email="wangwei@hotmail.com",Age=51, Dynasty=DynastyEnum.唐,
                    PhotoPath="4.jpg"},
                new StudentModel{Id=5,Name="屈原",Email="quyuan@outlook.com",Age=88,Dynasty=DynastyEnum.先秦,
                    PhotoPath="5.jpg"},
                new StudentModel{Id=6,Name="苏轼",Email="sushi@163.com",Age=31,Dynasty=DynastyEnum.宋,
                    PhotoPath="6.jpg"},
                new StudentModel{Id=7,Name="陶渊明",Email="taoyuanming@hotmail.com",Age=25,Dynasty=DynastyEnum.南北朝,
                    PhotoPath="7.jpg"},
                new StudentModel{Id=8,Name="李商隐",Email="lishangyin@gmail.com",Age=30, Dynasty=DynastyEnum.唐,
                    PhotoPath="8.jpg"},
            };
        }


        public StudentModel GetStudentById(int id)
        {
            return _students.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<StudentModel> GetStudents()
        {
            return _students;
        }

        public StudentModel Add(StudentModel studentModel)
        {
            studentModel.Id = _students.Max(x => x.Id) + 1;
            _students.Add(studentModel);
            return studentModel;
        }

        public StudentModel Update(StudentModel studentModel)
        {
            StudentModel student = _students.FirstOrDefault(x => x.Id == studentModel.Id);
            if (student != null)
            {
                student.Name = studentModel.Name;
                student.Age = studentModel.Age;
                student.Email = studentModel.Email;
                student.Dynasty = studentModel.Dynasty;
            }

            return student;
        }

        public StudentModel Delete(int id)
        {
            StudentModel student = _students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                _students.Remove(student);
            }
            return student;
        }
    }
}
