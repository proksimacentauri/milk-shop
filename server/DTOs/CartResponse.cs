using server.Models;

namespace server.DTOs;
public class CartResponse
{
    public required string CartId { get; set; }
    public required List<CartItem> CartItems{ get; set; }  
}
