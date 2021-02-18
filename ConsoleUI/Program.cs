using Business.Abstract;
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
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand {BrandName = "Ford" });
            //brandManager.Add(new Brand { BrandName = "Wolkswagen" });
            //brandManager.Add(new Brand { BrandName = "BMW" });

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Black" });
            //colorManager.Add(new Color { ColorName = "White" });
            //colorManager.Add(new Color { ColorName = "Red" });
            //colorManager.Add(new Color { ColorName = "Grey" });

            //FindCarById(2);

            // ListCarsWithBrandAndColor();

            //ListCarsWithDescriptionAndPrice();
        }

        private static void FindCarById(int i)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car();
            car = carManager.GetById(i).Data;
            Console.WriteLine("-----------------------");
            Console.WriteLine("ID:\t{0}\nName:\t{1}\nYear:\t{2}\nDesc:\t{3}\nPrice:\t{4} TL", car.Id, car.CarName, car.ModelYear, car.Description, car.DailyPrice);
            Console.WriteLine("----------END----------");
        }

        private static void ListCarsWithDescriptionAndPrice()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Name:\t{0}\nDesc:\t{1}\nPrice:\t{2} TL", item.CarName, item.Description, item.DailyPrice);
            }
            Console.WriteLine("----------END----------");
        }

        private static void ListCarsWithBrandAndColor()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Name:\t{0}\nBrand:\t{1}\nColor:\t{2}\nPrice:\t{3} TL", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);
            }
            Console.WriteLine("----------END----------");
        }
    }
}
