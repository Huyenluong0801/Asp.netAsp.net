using Microsoft.EntityFrameworkCore;
using VoKhanhHuyenLuong_2122110521.Model;

namespace VoKhanhHuyenLuong_2122110521.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Quan hệ One-to-Many giữa Product và Brand
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId)
                .IsRequired(); // 🔹 Đảm bảo không có BrandId null

            // Quan hệ One-to-Many giữa Product và Category
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .IsRequired(); // 🔹 Đảm bảo không có CategoryId null

            // Quan hệ One-to-Many giữa Product và User
            modelBuilder.Entity<Product>()
                .HasOne(p => p.User)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UserId)
                .IsRequired(); // 🔹 Đảm bảo không có UserId null

            base.OnModelCreating(modelBuilder);
        }
    }
}
