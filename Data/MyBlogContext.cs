using Microsoft.EntityFrameworkCore;
using NewsSite.Models.Account;
using NewsSite.Models.Categories;
using NewsSite.Models.Comments;
using NewsSite.Models.Posts;

namespace NewsSite.Data
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
            
        }

        #region User
        public DbSet<User> Users { get; set; }
        #endregion

        #region Post
        public DbSet<Post> Posts { get; set; }
        #endregion   

        #region Category
        public DbSet<Category> Categories { get; set; }
        #endregion

        #region Comment
        public DbSet<Comment> comments { get; set; }
        #endregion

        #region PostComments
        public DbSet<PostComments> PostComments { get; set; }
        #endregion



        #region on model creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
