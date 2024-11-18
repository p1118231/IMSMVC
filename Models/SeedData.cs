using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IMSMVC.Data;
using System;
using System.Linq;

namespace IMSMVC.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new InventoryContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<InventoryContext>>()))
        {
            if (!context.Category.Any())
    {
        context.Category.AddRange(
            new Category { CategoryName = "Electronics" },
            new Category { CategoryName = "Clothing" },
            new Category { CategoryName = "Beauty and Personal care" },
            new Category { CategoryName = "Home and kitchen" },
            new Category { CategoryName = "Sports and Outdoors" },
            new Category { CategoryName = "Toys and Games" },
            new Category { CategoryName = "Automotive" },
            new Category { CategoryName = "Food and Beverage" },
            new Category { CategoryName = "Pet Supplies" },
            new Category { CategoryName = "Health and Wellness" },
            new Category { CategoryName = "Office Supplies" }
            
        );
        context.SaveChanges();
    }

    // Seed Brands if not already present
    if (!context.Brand.Any())
    {
        context.Brand.AddRange(
            new Brand { BrandName = "Samsung" },
            new Brand { BrandName = "Nike" },
            new Brand { BrandName = "Sony" },
            new Brand { BrandName = "Dove" },
            new Brand { BrandName = "IKEA" },
            new Brand { BrandName = "Under Armour" },
            new Brand { BrandName = "LEGO" },
            new Brand { BrandName = "Oakley" },
            new Brand { BrandName = "Nintendo" },
            new Brand { BrandName = "BBC" },
            new Brand { BrandName = "Ford" }
        );
        context.SaveChanges();
    }
        }
    }
    
}