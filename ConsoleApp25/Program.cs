using ConsoleApp25.Models;
using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Azerbaijan********");
            Console.WriteLine("Min ehali sayini daxil edin");
            long min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max ehali sayini daxil edin");
            long max = Convert.ToInt32(Console.ReadLine());
            Country country = new Country("Azerbaijan",1000000);
            country.City.Add(new City("Baki", 400000));
            country.City.Add(new City("Salyan", 72000));
            country.City.Add(new City("Sabirabad", 139000));
            country.City.Add(new City("Agstafa", 12000));
            country.City.Add(new City("Quba", 39000));
            country.City.Add(new City("Seki", 52100));

            country.FindAllByPopulation(min,max);
            Console.WriteLine("******Turkey******");
            Console.WriteLine("Min ehali sayini daxil edin");
            long min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max ehali sayini daxil edin");
            long max1 = Convert.ToInt32(Console.ReadLine());
            Country country1 = new Country("Turkey", 9000000);
            country1.City.Add(new City("Ankara", 1000000));
            country1.City.Add(new City("Istanbul", 1200000));
            country1.City.Add(new City("Kutahya", 500000));
            country1.City.Add(new City("Eskisehir", 650000));
            country1.City.Add(new City("Trabzon", 900000));
            country1.City.Add(new City("Usak", 300000));
            country1.City.Add(new City("Aydin", 120000));
            country1.City.Add(new City("Izmir", 800000));
            country1.City.Add(new City("Canakkale", 220000));
            country1.FindAllByPopulation(min1, max1);

        }
    }
}
