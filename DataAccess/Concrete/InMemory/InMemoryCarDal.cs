using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=2008, DailyPrice=95000, Description="Bir"},
                new Car{ Id=2, BrandId=1, ColorId=2, ModelYear=2018, DailyPrice=150000, Description="İki"},
                new Car{ Id=3, BrandId=2, ColorId=1, ModelYear=2010, DailyPrice=100000, Description="Üç"},
                new Car{ Id=4, BrandId=2, ColorId=1, ModelYear=2015, DailyPrice=180000, Description="Dört"},
                new Car{ Id=5, BrandId=2, ColorId=1, ModelYear=2021, DailyPrice=400000, Description="Beş"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
