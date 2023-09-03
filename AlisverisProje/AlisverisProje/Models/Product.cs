using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlisverisProje.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? UrunAd { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Categories { get; set; }
        public string ImageUrl { get; set; }
       
    }
}
