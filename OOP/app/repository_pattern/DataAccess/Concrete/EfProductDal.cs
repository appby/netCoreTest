using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.Entity;
using repository_pattern.DataAccess;
using repository_pattern.DataAccess.Abstract;

namespace repository_pattern.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository // EF = Entity FrameWork, Dal= DataAccessLayer
    {
        public void Create(Product entity)
        {
            Console.WriteLine("EfProduct Created.");
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