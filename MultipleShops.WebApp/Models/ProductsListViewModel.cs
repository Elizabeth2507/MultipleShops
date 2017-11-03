using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MultipleShops.Domain.Entities;

namespace MultipleShops.WebApp.Models
{
    public class ProductsListViewModel
    {
        public string ShopTitle { get; set; }

        public IEnumerable<Product> Products { get; set; }
        //public string CurrentShop { get; set; }
    }
}