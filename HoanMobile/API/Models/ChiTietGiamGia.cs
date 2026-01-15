using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ChiTietGiamGia
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public Guid ChiTietProductId { get; set; }
        public string GiamGiaId { get; set; }
        public virtual ChiTietProduct ChiTietProduct { get; set; }
        public virtual GiamGia GiamGia { get; set; }
    }
}
