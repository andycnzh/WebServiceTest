using GlobalWeatherTest.GlobalWeatherReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalWeatherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string endpoint = "GlobalWeatherSoap12";

            GlobalWeatherSoapClient client = new GlobalWeatherSoapClient(endpoint);

            string citiesList = client.GetCitiesByCountry("China");

            Console.WriteLine(citiesList);

            Console.ReadLine();
        }
    }
}
