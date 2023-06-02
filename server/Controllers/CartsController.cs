using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.DTOs;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ShopContext _context;

        public CartsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        {
            return await _context.Cart.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartResponse>> GetCart(string id)
        {
            var cart = await _context.Cart.Include(x => x.CartItems).ThenInclude(x => x.Product).SingleOrDefaultAsync(x => x.CartId == id);
            
            if (cart == null)
            {
                return NotFound();
            }

            return new CartResponse() {
                CartId = cart.CartId,
                CartItems = cart.CartItems,
            };
        }

        [HttpPost]
        public async Task<ActionResult<Cart>> CreateCart()
        {
            var newCart = new Cart {
                CartId = Guid.NewGuid().ToString(),
                CartItems = new List<CartItem>() {}
            };
            _context.Cart.Add(newCart);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction("GetCart", new { id = newCart.CartId }, newCart);
        }

        [HttpPost("{cartId}/Order")]
        public async Task<ActionResult<Cart>> PlaceOrder(string cartId)
        {
            var cart = await _context.Cart.Include(x => x.CartItems).ThenInclude(x => x.Product).SingleOrDefaultAsync(x => x.CartId == cartId);
            
            if (cart == null)
            {
                return NotFound();
            }
                // Check stock and reduce it
            foreach (var cartItem in cart.CartItems)
            { 
                if (cartItem.Product.Storage < cartItem.Quantity)
                {
                    return BadRequest($"Not enough stock for product {cartItem.ProductId}");
                }

                cartItem.Product.Storage -= cartItem.Quantity;
            }

            var newOrder = new Order {
                OrderItems = cart.CartItems,
                Status = "pending"
            };
            _context.Orders.Add(newOrder);
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction("PlaceOrder", new { id = newOrder.Id }, newOrder);
        }


        [HttpPost("{cartId}")]
        public async Task<IActionResult> AddToCart(string cartId, string productId, int quantity)
        {
            // Create new CartItem
            var product = await _context.Product.FindAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            if (quantity > product.Storage || quantity == 0) 
            {
                return BadRequest();
            }

            var cartItem = new CartItem
            {
                ItemId = Guid.NewGuid().ToString(),
                CartId = cartId,
                ProductId = productId,
                Quantity = quantity
            };

            _context.CartItem.Add(cartItem);
            await _context.SaveChangesAsync();

            return Ok(cartItem);
        }

        [HttpDelete("{cartId}/Item/{itemId}")]
        public async Task<IActionResult> RemoveFromCart(string cartId, string itemId)
        {
            var cartItem = await _context.CartItem.FindAsync(itemId);
            if (cartItem == null)
            {
                return NotFound();
            }

            _context.CartItem.Remove(cartItem);
            await _context.SaveChangesAsync();

            return Ok(cartItem);
        }

        private bool CartExists(string id)
        {
            return (_context.Cart?.Any(e => e.CartId == id)).GetValueOrDefault();
        }
    }
}
