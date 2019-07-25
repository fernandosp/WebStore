using System;
using System.Collections.Generic;
using WebStore.Domain;
using WebStore.Repository;
using WebStore.Repository.Interface;
using WebStore.Service.Interface;

namespace WebStore.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public void Add(Car carro)
        {
            _repository.Add(carro);
        }

        public List<Car> GetAll()
        {
          return  _repository.GetAll();
        }

        public List<Car> GetByBrand(string brand)
        {
            return _repository.GetByBrand(brand);
        }
    }
}
