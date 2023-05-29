
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class Product
    {
        [Key]
        public required string ProductId { get; set; }
        public required string Name { get; set; }
        public int Storage { get; set; }
        public string? Type { get; set; }
    }
}