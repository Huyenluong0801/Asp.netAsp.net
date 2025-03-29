using VoKhanhHuyenLuong_2122110521.Model;
using Microsoft.EntityFrameworkCore;

namespace VoKhanhHuyenLuong_2122110521.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
