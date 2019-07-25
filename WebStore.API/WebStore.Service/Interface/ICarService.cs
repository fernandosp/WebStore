using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain;

namespace WebStore.Service.Interface
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrand(string brand);
        void Add(Car carro);
    }
}
