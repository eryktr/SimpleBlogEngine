using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlogEngine.DAL;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _repository;

        public HomeController(IBlogRepository br)
        {
            _repository = br;
        }

        public IActionResult Index()
        {
            //var posts = _repository.ListAll<Post>() as IEnumerable<Post>;
            //return View(posts);
            return View();
        }


    }
}