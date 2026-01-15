namespace API.Models.DTO
{
    public class ProductDTO
    {
        public string? Id { get; set; }
        public required string Ten { get; set; }
        public Guid? TacGiaId { get; set; }
        public string? TacGia { get; set; }
        public Guid? NhaXuatBanId { get; set; }
        public string? NhaXuatBan { get; set; }
        public TimeOnly? HanSuDung { get; set; }
        public bool TrangThai { get; set; } 
        public string? Mota { get; set; }
        public string? AnhDaTai { get; set; }
        public decimal Gia { get; set; }
    }
}
