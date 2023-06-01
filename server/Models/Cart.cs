using System.ComponentModel.DataAnnotations;

namespace server.Models;
public class Cart
{
    [Key]
    public string CartId { get; set; }
    public List<CartItem> CartItems{ get; set; }
}
