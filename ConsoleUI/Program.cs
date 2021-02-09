using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.GetAll(); //Bu bize bir liste döndürecek

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            carManager.Add(new Entities.Concrete.Car {Id = 10, BrandId= 3, ColorId = 15, DailyPrice = 500, Description = "bişey", ModelYeaer = 1990 });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
