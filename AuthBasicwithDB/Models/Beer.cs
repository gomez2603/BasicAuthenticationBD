using System.ComponentModel.DataAnnotations;

namespace AuthBasicwithDB.Models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public decimal Alcohol { get; set; }
    
    }
}
