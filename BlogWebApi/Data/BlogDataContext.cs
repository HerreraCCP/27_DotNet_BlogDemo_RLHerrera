using BlogWebApi.Data.Mappings;
using BlogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApi.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=localhost,1433;Initial Catalog=Blog;User ID=sa;Password=A123456s;TrustServerCertificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}