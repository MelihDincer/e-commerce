using System.ComponentModel.DataAnnotations;

namespace API.Entity;

public class Product 
{
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal ProductPrice{ get; set; }
    public bool IsActive { get; set; }
    public string ImageUrl { get; set; }
    public int Stock { get; set; }
}