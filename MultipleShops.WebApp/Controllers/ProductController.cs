using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleShops.Domain.Abstract;
using MultipleShops.Domain.Concrete;
using MultipleShops.Domain.Entities;
using MultipleShops.WebApp.Models;
using System.Collections;
using System.IO;

namespace MultipleShops.WebApp.Controllers
{
    public class ProductController : Controller
    {
        protected IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult LoadProduct(int id, int? skipCount )
        {
            System.Threading.Thread.Sleep(4000);
            skipCount = skipCount ?? 0;
            IEnumerable<Product> products = unitOfWork.ProductRepository.DataAll
                .Where(x => x.ShopId == id)
                .Skip(skipCount.Value)
                .Take(3);
            IEnumerable<Product> productCount = unitOfWork.ProductRepository.DataAll
                .Where(x => x.ShopId == id);

            /*var prodInSelectedShopDb = productCount.Count();
            if (products.Any())
            {
                string modelString = RenderRazorViewToString("LoadProduct", products);
                return PartialView(new { ModelString = modelString, ModelCount = prodInSelectedShopDb });
            }
            */

            return PartialView(products);
            
             

        }
        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext =
                     new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
        // GET: Product
        /*public PartialViewResult ShopProducts()
        {
            return PartialView("_Product", unitOfWork.ProductRepository.DataAll);
        }*/
    }
}