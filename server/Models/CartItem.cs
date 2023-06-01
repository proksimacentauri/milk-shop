using System.ComponentModel.DataAnnotations;

namespace server.Models;
public class CartItem
{   
    [Key]
    public string ItemId { get; set; }
    public string CartId { get; set; }
    
    public string ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
}
