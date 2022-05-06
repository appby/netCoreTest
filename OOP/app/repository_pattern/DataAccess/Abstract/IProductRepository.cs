using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
    }
}