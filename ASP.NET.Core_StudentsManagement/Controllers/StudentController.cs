using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.Core_StudentsManagement.Models;
using ASP.NET.Core_StudentsManagement.Services;
using ASP.NET.Core_StudentsManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Core_StudentsManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        //注册WebHostEnvironment对象，该对象包含当前运行环境的各种信息。
        private readonly IWebHostEnvironment _hostEnvironment;

        public StudentController(IStudentService studentService, IWebHostEnvironment hostEnvironment)
        {
            _studentService = studentService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<StudentModel> students = _studentService.GetStudents();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            StudentModel student = _studentService.GetStudentById(id);

            if (student == null)
            {
                Response.StatusCode = 404;
                return View("StudentNotFound", id);
            }
            return View(student);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            //throw new Exception();
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(StudentModel student)
        //{
        //    //如果提交的信息，通过模型验证，则返回到Details页面。
        //    if (ModelState.IsValid)
        //    {
        //        StudentModel studentModel = _studentService.Add(student);
        //        return RedirectToAction("Details", new { id = studentModel.Id });
        //    }
        //    //否则放回到当前的View，Create()操作方法。
        //    return View();
        //}

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName;
                StudentModel student = studentViewModel.Student;

                if (studentViewModel.Photo != null)
                {
                    //指定上传的文件储存在wwwroot/images文件夹中
                    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                    //为上传的文件添加GUID文件名
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + studentViewModel.Photo.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    
                    //把上传的文件从内存中拷贝到硬盘上
                    studentViewModel.Photo.CopyToAsync(new FileStream(filePath, FileMode.Create));
                    student.PhotoPath = uniqueFileName;
                }
                else
                {
                    //如果用户没有上传图片，则使用默认图片。
                    student.PhotoPath = "default.jpg";
                }

                //把新创建的student提交到数据库
                _studentService.Add(student);
                //完成后，返回到详情页面
                return RedirectToAction("Details", new { id = studentViewModel.Student.Id });
            }

            //如果没有通过模型校验，返回Create()操作方法。
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            StudentModel student = _studentService.GetStudentById(id);
            if (student != null)
            {
                StudentCreateViewModel viewModel = new StudentCreateViewModel();
                viewModel.Student = student;
                return View(viewModel);
            }
            else
            {
                throw new Exception("The student doesn't exist.");
            }
        } 
    }
}
