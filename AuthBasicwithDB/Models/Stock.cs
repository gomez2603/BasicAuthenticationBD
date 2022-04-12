using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthBasicwithDB.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BeerId { get; set; }
        [ForeignKey("BeerId")]
        public Beer Beer { get; set; }
        public int Quantity { get; set; }
    }
}
