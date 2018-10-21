using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Session;
using SimpleBlogEngine.DAL;
using SimpleBlogEngine.Models;


namespace SimpleBlogEngine.Controllers
{
    public class LoginController : Controller
    {
        private readonly BlogContext _context;
        public LoginController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorize()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            var result = _context.Users.Where(u => u.Username == username && u.Password == password);
            if (result.Any())
            {
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("isAdmin", result.First().IsAdmin.ToString());
                return new RedirectResult("/");
            }
            else
            {
                return new RedirectResult("/Login");
            }
            
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return new RedirectResult("/");
        }
    }
}