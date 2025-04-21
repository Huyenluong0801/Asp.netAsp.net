using System;

namespace VoKhanhHuyenLuong_2122110521.Model
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }


}
