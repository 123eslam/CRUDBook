using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetS()
        {
            HttpContext.Session.SetInt32("Age", 21);
            HttpContext.Session.SetString("Name", "Eslam");
            return Content("Session Has Been Setted");
        }


        public IActionResult ReadS()
        {
            var name = HttpContext.Session.GetString("Name");
            var age = HttpContext.Session.GetInt32("Age");
            return Content($"Name:{name}, Age:{age}");
        }



        public IActionResult SetC()
        {
            var cp = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1),
            };

            HttpContext.Response.Cookies.Append("Dept", "MVC", cp);
            HttpContext.Response.Cookies.Append("Theme", "Dark", cp);
            return Content("Cookie Has Been Setted");
        }

        public IActionResult ReadCookie()
        {
            var dept = HttpContext.Request.Cookies.FirstOrDefault(c => c.Key == "Dept");
            var theme = HttpContext.Request.Cookies.FirstOrDefault(c => c.Key == "Theme");
            return Content($"Cookie Has Been Read , Dept:{dept}, Theme:{theme}");
        }
    }
}
