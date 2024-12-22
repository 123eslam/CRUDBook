using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MVC1.Context;
using MVC1.Models;
using MVC1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class AuthUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Regster()
        {
            return View();
        }
		public IActionResult SubmitRegister(User newUser)
		{
			var context = new AppBooksContext();
			context.Users.Add(newUser);
			context.SaveChanges();
			return RedirectToAction("Login");
		}

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> SubmitLogin(Login login)
        {
			var context = new AppBooksContext();
			var user = context.Users.FirstOrDefault(u => (u.Emile == login.Email && u.Passwored == login.Passwored));
			if (user == null)
			{
				return View("Login");
			}

			var IdentityClaims = new ClaimsIdentity("MyCookie");
			IdentityClaims.AddClaim(new Claim("Name", user.Name));
			IdentityClaims.AddClaim(new Claim("Role", user.Rol));
			var princiable = new ClaimsPrincipal(IdentityClaims);
			await HttpContext.SignInAsync("MyCookie", princiable, new AuthenticationProperties()
			{
				IsPersistent = true,
				ExpiresUtc = DateTime.UtcNow.AddHours(4)
			});
			return RedirectToAction("Index", "Home");
		}

		
	}
}
