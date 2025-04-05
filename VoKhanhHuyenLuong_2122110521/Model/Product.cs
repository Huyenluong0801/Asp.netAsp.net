using VoKhanhHuyenLuong_2122110521.Model;



    public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public double Price { get; set; }

    // Thời gian tạo và cập nhật
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // 🔹 Liên kết với Brand (One-to-Many)
    public int BrandId { get; set; }
    public Brand? Brand { get; set; }

    // 🔹 Liên kết với Category (One-to-Many)
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    // 🔹 Liên kết với User (One-to-Many)
    public int UserId { get; set; }
    public User? User { get; set; }
}
