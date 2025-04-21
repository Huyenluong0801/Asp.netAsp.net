using System;
using System.Collections.Generic;

namespace VoKhanhHuyenLuong_2122110521.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalAmount { get; set; }

        // Quan hệ với User
        public User User { get; set; }

        // Danh sách chi tiết đơn hàng
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
