using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleShops.Domain.Entities;
using MultipleShops.Domain.Abstract;

namespace MultipleShops.Domain.Concrete
{
    public class UnitOfWork: IUnitOfWork
    {
        private EFDbContext dbContext = new EFDbContext();

        private Repository<Shop> shopRepository;
        private Repository<Product> productRepository;

        public IRepository<Shop> ShopRepository
        {
            get
            {
                if (shopRepository == null)
                {
                    shopRepository = new Repository<Shop>(dbContext);
                }
                return shopRepository;
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if(productRepository == null)
                {
                    productRepository = new Repository<Product>(dbContext);
                }
                return productRepository;
            }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

    }
}
