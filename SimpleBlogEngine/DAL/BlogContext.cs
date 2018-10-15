using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SimpleBlogEngine.Models;
using DbContext = System.Data.Entity.DbContext;

namespace SimpleBlogEngine.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Post> Posts { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<PostCategory> PostCategories { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<PostAuthor> PostAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
