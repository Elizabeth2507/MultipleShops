using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleShops.Domain.Abstract
{
    public interface IRepository<T> where T: class
    {
        //Method to get all rows in a table
        IEnumerable<T> DataAll { get; }
    }
}
