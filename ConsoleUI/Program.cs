using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId=3, BrandId=3, ColorId=2, ModelYear=2017, DailyPrice=500, Description="Kiralık"});
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
