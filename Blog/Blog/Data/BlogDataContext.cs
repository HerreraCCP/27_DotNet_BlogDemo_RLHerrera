namespace Blog.Data
{
    using Blog.Data.Mappings;
    using Blog.Models;
    using Microsoft.EntityFrameworkCore;

    public class BlogDataContext : DbContext
    {

        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options) { }

        public DbSet<Blog.Models.Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}