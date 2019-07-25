using System.Collections.Generic;

namespace WebStore.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {        
        List<TEntity> GetAll();
        void Add(TEntity obj);
    }
}
