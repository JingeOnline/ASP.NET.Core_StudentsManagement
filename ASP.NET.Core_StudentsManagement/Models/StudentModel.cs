using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Core_StudentsManagement.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name为必填字段")]
        public string Name { get; set; }
        public int Age { get; set; }
        [RegularExpression(@"^[A-Za-z0-9\u4e00-\u9fa5]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$",ErrorMessage ="不是有效的邮箱")]
        public string Email { get; set; }
        public DynastyEnum Dynasty { get; set; }

        //图片文件的路径
        public string PhotoPath { get; set; }
    }
}
