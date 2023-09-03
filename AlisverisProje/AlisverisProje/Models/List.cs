using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using AlisverisProje.Areas.Identity.Data;

namespace AlisverisProje.Models
{
    public class List
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int DetailId { get; set; }
        public Detail Detail { get; set; }
        
       

    }
}
