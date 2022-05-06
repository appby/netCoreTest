using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.DataAccess.Abstract;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Concrete
{
    public class MySqlProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("MySqlProduct Created.");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}