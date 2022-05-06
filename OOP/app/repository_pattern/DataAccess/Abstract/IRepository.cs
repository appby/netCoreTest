using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetByID(int id);
        void Update (TEntity entity);
        void Create (TEntity entity);
        void Delete (int id);
        
    }
}