using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class BoNhoTrong
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public string Mota { get; set; }
        public ICollection<ChiTietProduct>? ChiTietProduct { get; set; }
    }
}
