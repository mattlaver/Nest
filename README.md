Nest Play
====

A C# library for reading and writing to Nest Thermostats (https://nest.com/uk/)

Simple to use:

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
    
  On the roadmap:
  
  * Events to listen to data changes
  * Update Nest settings
  * Windows 8 Phone App with Live tile
  
