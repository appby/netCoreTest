using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.DataAccess.Abstract;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository // EF = Entity FrameWork, Dal= DataAccessLayer
    {
        public void Create(Category entity)
        {
            Console.WriteLine("EfProduct Created.");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}