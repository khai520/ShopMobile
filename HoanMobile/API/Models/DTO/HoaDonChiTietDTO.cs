

namespace API.Models.DTO
{
    public class HoaDonChiTietDTO
    {
        public Guid Id { get; set; }
        public int Soluong { get; set; }
        public bool TrangThai { get; set; } = true;
        public decimal ThanhTien { get; set; }
        public string HoaDonId { get; set; }
        public Guid? ChiTietProductId { get; set; }
        public string? ComboId { get; set; }
    }
}
