using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class GioHang
    {
        [Key]
        public string Id { get; set; }
        public int Soluong { get; set; }
        public decimal TongGia { get; set; }
        public string? ComboId { get; set; }
        public Guid? ChiTietProductId { get; set; }
        public string KhachHangId { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual ChiTietProduct ChiTietProduct { get; set; }
    }
}
