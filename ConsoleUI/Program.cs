using Business.Concrete;
using Core.Entities.Concrete;
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
            //Test();
            ////Test2(carManager);
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();
            //if (result.Success)
            //{
            //    foreach (var c in result.Data)
            //    {
            //        Console.WriteLine(c.CarId + " " + c.BrandName + " " + c.ColorName + " " + c.DailyPrice + " " + c.ModelYear);
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //UserTest();

            //CustomerTest();
            //RentalTest();



            //getbyId, add, getall,delete,update
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.Add(new Rental { CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 9, 26), ReturnDate = new DateTime(2021, 9, 28) });
            //Console.WriteLine(result.Message);
            var result2 = rentalManager.GetAll();
            if (result2.Success)
            {
                foreach (var rental in result2.Data)
                {
                    Console.WriteLine("CarId : " + rental.CarId
                        + " CustomerId : " + rental.CustomerId +
                        " RentDate : " + rental.RentDate +
                        " ReturnDate : " + rental.ReturnDate);
                }
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { UserId = 3, CompanyName = "Bedir" });
            Console.WriteLine(result.Message);
            var result2 = customerManager.GetAll();
            if (result2.Success)
            {
                foreach (var customer in result2.Data)
                {
                    Console.WriteLine("Id : " + customer.UserId + " CompanyName : " + customer.CompanyName);
                }
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        //private static void Test2(CarManager carManager)
        //{
        //    Console.WriteLine("---Car Nesnesi İçin Add Metodu---");
        //    carManager.Update(new Car { CarId = 4, BrandId = 4, ColorId = 3, DailyPrice = 350, Description = "Kiralık", ModelYear = 2012 });


        //    Console.WriteLine("\n---Car Nesnesi İçin GetAll metodu---");

        //    foreach (var c in carManager.GetAll())
        //    {
        //        Console.WriteLine("\t=> " + c.CarId);
        //    }

        //    Console.WriteLine("\n---Car Nesnesi İçin GetById Metodu---");
        //    Console.WriteLine("\t=> " + carManager.GetById(4).BrandId);
        //}

        //private static void Test()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Add(new Color { ColorName = "Gri" });
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    Console.WriteLine(brandManager.GetById(13).BrandName);
        //    foreach (var b in brandManager.GetAll())
        //    {
        //        Console.WriteLine(b.BrandName);
        //    }
        //}

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result2 = userManager.Add(new User { FirstName = "Ad", LastName = "Soyad", Email = "ad-soyad@hotmail.com" });
            Console.WriteLine(result2.Message);
            var result = userManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName + " " + user.Email + " ");

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
