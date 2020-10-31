using ASP.NET.Core_StudentsManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.ViewModels
{
    public class StudentCreateViewModel
    {
        public StudentModel Student { get; set; }
        public IFormFile Photo { get; set; }
    }
}
