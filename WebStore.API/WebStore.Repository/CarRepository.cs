using Dapper;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domain;
using WebStore.Repository.Interface;

namespace WebStore.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {        
        public List<Car> GetByBrand(string brand)
        {
           return _connection.Query<Car>($@"Select * from Car where name like '% {brand} %' ").ToList();
        }
    }
}
