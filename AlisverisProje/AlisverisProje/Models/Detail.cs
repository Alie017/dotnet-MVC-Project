using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlisverisProje.Models
{
    public class Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DetailName { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string DetailText { get; set; }
        public Product Product { get; set; }
    }
}
