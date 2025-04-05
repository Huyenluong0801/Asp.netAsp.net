namespace VoKhanhHuyenLuong_2122110521.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        // Một Category có thể có nhiều Product
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
