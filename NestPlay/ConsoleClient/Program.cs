using System;
using System.Configuration;
using System.Linq;
using NestPlay;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var accesstoken = ConfigurationManager.AppSettings["accesstoken"];
            var nest = new Nest(accesstoken);
            var response = nest.Get();

            Console.WriteLine(response.Devices.Thermostats.First().Value.ambient_temperature_c);
            Console.ReadLine();
        }
    }
}
