using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IMSMVC.Models;
using IMSMVC;

namespace IMSMVC.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext (DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<IMSMVC.Models.Product> Product { get; set; } = default!;
        public DbSet<IMSMVC.Category> Category { get; set; } = default!;
        public DbSet<IMSMVC.Brand> Brand { get; set; } = default!;
    }
}
