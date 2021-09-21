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
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName="Gri" });
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Console.WriteLine(brandManager.GetById(13).BrandName);
            //foreach (var b in brandManager.GetAll())
            //{
            //    Console.WriteLine(b.BrandName);
            //}

            CarManager carManager = new CarManager(new EfCarDal());

            //Console.WriteLine("---Car Nesnesi İçin Add Metodu---");
            //carManager.Update(new Car { CarId=4, BrandId=4, ColorId=3, DailyPrice=350, Description="Kiralık", ModelYear=2012});


            //Console.WriteLine("\n---Car Nesnesi İçin GetAll metodu---");

            //foreach (var c in carManager.GetAll())
            //{
            //    Console.WriteLine("\t=> "+c.CarId);
            //}

            //Console.WriteLine("\n---Car Nesnesi İçin GetById Metodu---");
            //Console.WriteLine("\t=> " + carManager.GetById(4).BrandId);

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.CarId + " "+c.BrandName+" "+c.ColorName+" " +c.DailyPrice+" "+ c.ModelYear);
            }

 
            //getbyId, add, getall,delete,update
        }
    }
}
