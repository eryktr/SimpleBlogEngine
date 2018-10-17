using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlogEngine.Models;

namespace SimpleBlogEngine.DAL
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;

        public BlogRepository(BlogContext context)
        {
            _context = context;
        }


        public IEnumerable<IEntity> ListAll(IEntity obj)
        {
            switch (obj)
            {
                case Category c:
                    return _context.Categories.ToList();

                case Post p:
                    return _context.Posts.ToList();

                case User u:
                    return _context.Posts.ToList();

                default:
                    return null;
    
            }
        }

        public void Add(IEntity obj)
        {
            switch (obj)
            {
                case Category c:
                    _context.Categories.Add(c);
                    break;

                case Post p:
                    _context.Posts.Add(p);
                    break;

                case User u:
                    _context.Users.Add(u);
                    break;
            }
        }
    }
}
