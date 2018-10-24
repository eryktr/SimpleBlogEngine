using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlogEngine.DAL;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogContext _context;

        public PostController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Remove(int id)
        {
            var post = _context.Posts.Where(p => p.PostID == id);
            _context.Posts.Remove(post.First());
            _context.SaveChanges();
            return new RedirectResult("/");
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Post p)
        {
            p.Date = DateTime.Now;
            _context.Posts.Add(p);
            _context.SaveChanges();
            return new RedirectResult("/");
        }
    }
}