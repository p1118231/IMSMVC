using System.ComponentModel.DataAnnotations;
using IMSMVC.Models;
namespace IMSMVC.Models;

public class Product
{
    public int Id { get; set; }

    // Foreign Keys
    [Required]
    public int CategoryId { get; set; }

    [Required]
    public int BrandId { get; set; }

    // Navigation Properties
    [Required]
    public Category? Category { get; set; }

    [Required]
    public Brand? Brand { get; set; }

    [Required]
    [Display(Name = "Product Name")]
    public string? ProductName { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    [Display(Name = "In Stock")]
    public bool InStock { get; set; }

    [Required]
    [Display(Name = "Restock Date")]
    [DataType(DataType.Date)]
    public DateTime? ExpectedRestock { get; set; }


    [Required]
    public int Quantity{get; set;}
}
