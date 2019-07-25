using System.Collections.Generic;
using WebStore.Domain;

namespace WebStore.Repository.Interface
{
    public interface ICarRepository : IRepository<Car>
    {
       List<Car> GetByBrand(string brand);       
    }
}
