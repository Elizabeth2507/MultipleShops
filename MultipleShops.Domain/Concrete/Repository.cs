using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MultipleShops.Domain.Abstract;

namespace MultipleShops.Domain.Concrete
{
    public class Repository<T>: IRepository<T> where T: class
    {
        protected EFDbContext dbcontext;
        protected DbSet<T> dbSet;

        public Repository(EFDbContext context)
        {
            dbcontext = context;
            dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> DataAll { get { return dbSet; } }

    }
}
