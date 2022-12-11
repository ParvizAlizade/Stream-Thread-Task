using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Models
{
    class City
    {
        public string CityName { get; set; }
        public long PopulationNumber { get; set; }

        public City(string cityName, long populationnumber)
        {
            CityName = cityName;
            PopulationNumber = populationnumber;
        }
    }
}
