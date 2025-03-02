using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CartController: ControllerBase
{
    private readonly DataContext _context;
    public CartController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<CartDTO>> GetCart()
    {
        var value = await GetOrCreate();      
        return CartToDTO(value);
    }

    [HttpPost]
    public async Task<IActionResult> AddItemToCart(int productId, int quantity)
    {
       var value = await GetOrCreate();
       var product = await _context.Products.FirstOrDefaultAsync(i => i.ProductId == productId);
       if(product == null)
            return NotFound("The product not in database");
       value.AddItem(product,quantity);
       var result = await _context.SaveChangesAsync() > 0;
       if (result)
            return CreatedAtAction(nameof(GetCart), CartToDTO(value));
        return BadRequest(new ProblemDetails {Title = "The product can not be added to cart."});
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteItemFromCart(int productId, int quantity)
    {
        var value = await GetOrCreate();
        value.DeleteItem(productId, quantity);
        var result = await _context.SaveChangesAsync() > 0;
        if(result)
            return Ok();
        return BadRequest(new ProblemDetails{Title="Problem removing item from the cart"});
    }

    private async Task<Cart> GetOrCreate()
    {
        var value = await _context.Carts.Include(i => i.CartItems).ThenInclude(i => i.Product).Where( i => i.CustomerId == Request.Cookies["customerId"]).FirstOrDefaultAsync();
        if(value == null)
        {
            var customerId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions() {
                Expires = DateTime.Now.AddMonths(1),
                IsEssential = true
            };
            Response.Cookies.Append("customerId", customerId, cookieOptions);
            value = new Cart { CustomerId = customerId };

            _context.Carts.Add(value);
            await _context.SaveChangesAsync();
        }
        return value;
    }

    private CartDTO CartToDTO(Cart cart)
    {
        return new CartDTO
        {
            CartId = cart.CartId,
            CustomerId = cart.CustomerId,
            CartItems = cart.CartItems.Select(item => new CartItemDTO {
                ProductId = item.ProductId,
                Name = item.Product.ProductName,
                Price = item.Product.ProductPrice,
                Quantity = item.Quantity,
                ImageUrl = item.Product.ImageUrl
            }).ToList()
        };
    }
}