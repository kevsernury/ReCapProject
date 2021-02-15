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
            /*    CarManager carManager = new CarManager(new InMemoryCarDal());
                carManager.GetAll(); //Bu bize bir liste döndürecek

                foreach (var item in carManager.GetAll())
                {
                    Console.WriteLine(item.Description);
                }


                Console.WriteLine("\nEklemeden sonra");
                carManager.Add(new Entities.Concrete.Car {Id = 10, BrandId= 3, ColorId = 15, DailyPrice = 500, Description = "Tesla", ModelYeaer = 1990 });
                foreach (var item in carManager.GetAll())
                {
                    Console.WriteLine(item.Description);
                }

                Console.WriteLine("\nSildikten sonra");
                carManager.Delete(new Entities.Concrete.Car { Id = 1 });
                foreach (var item in carManager.GetAll())
                {
                    Console.WriteLine(item.Description);
                }

                */

            CarManager carManager = new CarManager(new EfCarDal());
            

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Car newcar = new Car { Id = 10, BrandId = 3, ColorId = 15, DailyPrice = 500, Description = "Tesla", ModelYear = 1990 };


            carManager.Add(newcar);
            Console.WriteLine("\nTesla eklendi\n");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }



            carManager.Delete(newcar);
            Console.WriteLine("\nTesla silindi\n");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }



            Console.WriteLine("\nyenlış ekleme");
            carManager.Add(new Car { Id = 10, BrandId = 3, ColorId = 15, DailyPrice = 500, Description = "T", ModelYear = 1990 });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
