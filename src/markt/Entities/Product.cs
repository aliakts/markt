using System.ComponentModel.DataAnnotations;

namespace markt.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Summary { get; set; }
        public decimal Price { get; set; }
        [MaxLength(500)]
        public string Thumbnail { get; set; }
    }
}