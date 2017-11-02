using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleShops.Domain.Entities;

namespace MultipleShops.Domain.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Shop> ShopRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void Commit();
    }
}
