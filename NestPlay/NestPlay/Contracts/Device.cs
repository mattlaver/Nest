using System.Collections.Generic;

namespace NestPlay.Contracts
{
    public class Device
    {
        public IDictionary<string, Thermostat> Thermostats { get; set; }
      
    }
}