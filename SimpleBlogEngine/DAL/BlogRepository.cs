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

        public BlogRepository()
        {
            _context = new BlogContext();
        }


        public IEnumerable<IEntity> ListAll<T>() where T:IEntity
        {
            if (typeof(T) == typeof(Post))
            {
                return _context.Posts.ToList();
            }
            else if (typeof(T) == typeof(Category))
            {
                return _context.Categories.ToList();
            }
            else if (typeof(T) == typeof(User))
            {
                return _context.Users.ToList();
            }
            else
            {
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
