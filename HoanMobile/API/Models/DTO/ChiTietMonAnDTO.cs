using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models.DTO
{
    public class ChiTietMonAnDTO
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string? ChatLieu { get; set; }
        public string? NhaCungCap { get; set; }
        public string? BoNhoTrong { get; set; }
        public string? KichCo { get; set; }
        public string ProductId { get; set; }
        public decimal Gia { get; set; }
        public decimal GiaGiam { get; set; }
        public int Soluong { get; set; }
        public int SoNgayHSD { get; set; }
        public string? Mota { get; set; }
        public bool TrangThai { get; set; } = false;
        public Guid? KichCoId { get; set; }
        public Guid? LoaiViId { get; set; }
        public Guid? ChatLieuId { get; set; }
        public Guid? BoNhoTrongId { get; set; }
        public List<AnhDTO>? DanhSachAnh { get; set; }
        public int SoLuongDat { get; set; } = 1;
        public bool IsSelected { get; set; } = false;

    }
}
