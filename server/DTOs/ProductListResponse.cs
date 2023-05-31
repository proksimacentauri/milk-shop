
using server.Models;

namespace server.DTOs;
public class ProductListResponse
{
    public required List<Product> Data { get; set; }
    public required int TotalCount { get; set; }
}