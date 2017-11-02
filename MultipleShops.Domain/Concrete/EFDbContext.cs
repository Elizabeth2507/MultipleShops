using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MultipleShops.Domain.Entities;

namespace MultipleShops.Domain.Concrete
{
    public  class EFDbContext: DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
