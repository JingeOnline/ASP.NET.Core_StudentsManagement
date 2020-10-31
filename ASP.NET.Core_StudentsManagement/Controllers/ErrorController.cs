using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Core_StudentsManagement.Controllers
{
    public class ErrorController : Controller
    {
        //使用属性路由
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature>();
            ViewBag.OriginalPath = statusCodeResult.OriginalPath;
            ViewBag.OriginalQueryString = statusCodeResult.OriginalQueryString;

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "抱歉，您访问的页面不存在";
                    break;
            }

            return View("NotFound");
        }
    }
}
