using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Models
{
    class Country
    {
        public List<City> City = new List<City>();
        public string Name;
        public double TotalPopulation;
        public Country(string name, double totalpopulation)
        {
            Name = name;
            TotalPopulation = totalpopulation;
        }
        public void FindAllByPopulation(long min, long max)
        {
            List<City> list = new List<City>();
            foreach (var city in City)
            {
                if (city.PopulationNumber > min && city.PopulationNumber < max)
                {
                    list.Add(city);
                    Console.WriteLine($"{city.CityName}-{city.PopulationNumber}");
                }
            }
            if (list.Count >= 0)
            {
                Console.WriteLine($"{Name}-{TotalPopulation}");
            }
        }
    }
}
