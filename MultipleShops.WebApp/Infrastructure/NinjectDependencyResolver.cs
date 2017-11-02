using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Moq;
using MultipleShops.Domain.Abstract;
using MultipleShops.Domain.Entities;
using MultipleShops.Domain.Concrete;

namespace MultipleShops.WebApp.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            /*Mock<IRepository<Shop>> mock = new Mock<IRepository<Shop>>();
            mock.Setup(m => m.DataAll).Returns(new List<Shop>
            {
                new Shop { Name = "Pumpkin", Address = "14 Gikalo str", ShoppingHours = "Mon, Th, Fr" },
                new Shop { Name = "Vitadini", Address = "65 Korolev str", ShoppingHours = "Fr" },
                new Shop { Name = "Nine West", Address = "1 Plehanov str", ShoppingHours = "Mon, Wen" },
            });*/
            //kernel.Bind(typeof(IRepository<>)).ToConstant(mock.Object);
            //kernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }
    }
}