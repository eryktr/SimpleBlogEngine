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

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostAuthor> PostAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
