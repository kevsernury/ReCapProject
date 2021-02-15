using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        //Constucter method
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 15, ModelYear = 2015, DailyPrice = 100, Description = "Ford Fiesta"},
                new Car{Id = 2, BrandId = 1, ColorId = 10, ModelYear = 2018, DailyPrice = 130, Description = "Ford Focus"},
                new Car{Id = 3, BrandId = 2, ColorId = 15, ModelYear = 2016, DailyPrice = 140, Description = "Volkswagen Golf"},
                new Car{Id = 4, BrandId = 2, ColorId = 20, ModelYear = 2017, DailyPrice = 175, Description = "Volkswagen Passat"},
                new Car{Id = 5, BrandId = 3, ColorId = 10, ModelYear = 2017, DailyPrice = 110, Description = "Peugeot 308"},
                new Car{Id = 6, BrandId = 4, ColorId = 15, ModelYear = 2018, DailyPrice = 185, Description = "Toyota Corolla"},
                new Car{Id = 7, BrandId = 5, ColorId = 15, ModelYear = 2020, DailyPrice = 220, Description = "Honda Civic"},
            };
        }
         public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
