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
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
