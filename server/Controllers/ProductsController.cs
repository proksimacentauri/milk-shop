using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.DTOs;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(string searchParameter = "", string filter = "", int page = 0)
        {   
            var pageSize = 6;
            if (filter != string.Empty) 
            {
                return Ok(new ProductListResponse{ 
                    Data =  await  _context.Product.Where(product => product.Type == filter)
                    .Where(product => product.Name.Contains(searchParameter))
                    .Skip(pageSize * page)
                    .Take(pageSize).ToListAsync(),
                    TotalCount = _context.Product.Where(product => product.Type == filter)
                    .Where(product => product.Name.Contains(searchParameter)).Count()
                });
            }

            if (searchParameter != string.Empty) 
            {
                return Ok(new ProductListResponse { 
                    Data =  await  _context.Product.Where(product => product.Name
                    .Contains(searchParameter))
                    .Skip(pageSize * page)
                    .Take(pageSize).ToListAsync(),
                    TotalCount = _context.Product.Where(product => product.Name
                    .Contains(searchParameter)).Count()
                });
            }
    
            return Ok(new ProductListResponse{
                Data = await _context.Product.Skip(pageSize * page).Take(pageSize).ToListAsync(),
                TotalCount = _context.Product.Count()
            });
        }

        [HttpGet("category")]
        public async Task<IActionResult> GetProductCategories()
        {   
            return Ok(await _context.Product.Select(product => product.Type).Distinct().ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(string id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        
        [HttpPatch("{id}")]
        public async Task<IActionResult> OrderProduct(string id, int quantity)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            if (quantity > product.Storage || quantity == 0) 
            {
                return BadRequest();
            }
            
            product.Storage = product.Storage - quantity;
            _context.Entry(product).State = EntityState.Modified;

            await _context.SaveChangesAsync();
           
            return Ok(product);
        }
    }
}
