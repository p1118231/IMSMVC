using System.ComponentModel.DataAnnotations;
using IMSMVC.Models;
namespace IMSMVC;

public class Category
{
   
    public int Id { get; set; }

    [Required]
    [Display(Name = "Category Name")]
    public string? CategoryName { get; set; }
    
    // Navigation property for products
    public ICollection<Product>? Products { get; set; }
}