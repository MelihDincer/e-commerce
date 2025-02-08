using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductsController : ControllerBase 
{
    private readonly DataContext _context;
    public ProductsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var values = await _context.Products.ToListAsync();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int? id) 
    {
        if(id == null)
        {
            return NotFound();
        }
        var value = await _context.Products.FirstOrDefaultAsync(x=> x.ProductId == id);

        if(value == null)
        {
            return NotFound();
        }
        return Ok(value);
            
    }
}