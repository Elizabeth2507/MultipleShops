using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleShops.Domain.Concrete;
using MultipleShops.Domain.Abstract;
using MultipleShops.Domain.Concrete;

namespace MultipleShops.WebApp.Controllers
{
    public class ShopController : Controller
    {
        protected IUnitOfWork unitOfWork;
        //UnifOfWork unitOfWork = new UnifOfWork();
        // GET: Shop
        public ShopController(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }
        public ViewResult List()
        {
            return View(unitOfWork.ShopRepository.DataAll);
        }
    }
}