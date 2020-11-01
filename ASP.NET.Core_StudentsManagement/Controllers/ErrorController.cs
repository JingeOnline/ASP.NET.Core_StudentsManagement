using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASP.NET.Core_StudentsManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }


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
                    _logger.LogError($"访问路径错误：{statusCodeResult.OriginalPath}不存在");
                    break;
            }

            return View("NotFound");
        }
    }
}
