using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBlogEngine.DAL;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _blogContext;

        public HomeController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public IActionResult Index()
        {
            return HttpContext.Session.GetString("isAdmin") == "True" ? View("LoggedHome", _blogContext.Posts.ToList()) : View(_blogContext.Posts.ToList());
        }
    }
}