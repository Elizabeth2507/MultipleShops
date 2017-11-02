using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleShops.Domain.Entities
{
     public class Shop
    {
        public int ShopID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ShoppingHours { get; set; }
    }
}
