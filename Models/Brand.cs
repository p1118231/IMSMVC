using System.ComponentModel.DataAnnotations;
using IMSMVC.Models;

namespace IMSMVC;

public class Brand
{

    public int Id { get; set; }

    [Required]
    [Display(Name = "Brand Name")]
    public string? BrandName { get; set; }
    
    // Navigation property for products
    public ICollection<Product>? Products { get; set; }
}