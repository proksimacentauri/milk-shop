using System.ComponentModel.DataAnnotations;

namespace server.Models;
public class Order
{
    [Key]
    public int Id { get; set; }   
    public List<CartItem>? OrderItems { get; set; }
    public required string Status { get; set; }

}
