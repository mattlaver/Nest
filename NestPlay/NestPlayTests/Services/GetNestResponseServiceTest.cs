using System.Linq;
using NestPlay.Queries;
using NestPlay.Services;
using NSubstitute;
using Should;
using Xunit;

namespace NestPlayTests.Services
{
    public class GetNestResponseServiceTest
    {
        private string _nestResponse =
            "{\"thermostats\":{\"AqU5hBHtd0T1xZL4lETxUr61kmpWI1kB\":{\"locale\":\"en-GB\",\"temperature_scale\":\"C\",\"is_using_emergency_heat\":false,\"has_fan\":false,\"software_version\":\"4.2.5\",\"has_leaf\":false,\"device_id\":\"AqU5hBHtd0T1xZL4lETxUr61kmpWI1kB\",\"name\":\"Hallway\",\"can_heat\":true,\"can_cool\":false,\"hvac_mode\":\"heat\",\"target_temperature_c\":20.0,\"target_temperature_f\":68,\"target_temperature_high_c\":24.0,\"target_temperature_high_f\":75,\"target_temperature_low_c\":20.0,\"target_temperature_low_f\":68,\"ambient_temperature_c\":20.0,\"ambient_temperature_f\":69,\"away_temperature_high_c\":24.0,\"away_temperature_high_f\":76,\"away_temperature_low_c\":12.0,\"away_temperature_low_f\":54,\"structure_id\":\"_saUDvAzTFsgxJXmZSyDbMIrQzMlEeWO8PczmpAdzPHTFZ37j49K3w\",\"fan_timer_active\":false,\"name_long\":\"Hallway Thermostat\",\"is_online\":true,\"last_connection\":\"2014-10-19T20:53:34.310Z\"}}}";
        

        [Fact]
        public void Should_Return_Mapped_Device()
        {
            var getDeviceQuery = Substitute.For<IGetDeviceQuery>();
            getDeviceQuery.Execute().Returns(_nestResponse);
            var getNestResponseService = new GetNestResponseService(getDeviceQuery);

            var getNestResponse = getNestResponseService.Get();

            getNestResponse.ShouldNotBeNull();
            getNestResponse.Devices.ShouldNotBeNull();
            getNestResponse.Devices.Thermostats.Count.ShouldEqual(1);
            getNestResponse.Devices.Thermostats.First().Value.locale.ShouldEqual("en-GB");
            getNestResponse.Devices.Thermostats.First().Value.temperature_scale.ShouldEqual("C");
            getNestResponse.Devices.Thermostats.First().Value.is_using_emergency_heat.ShouldEqual(false);
            getNestResponse.Devices.Thermostats.First().Value.has_fan.ShouldEqual(false);
            getNestResponse.Devices.Thermostats.First().Value.software_version.ShouldEqual("4.2.5");
            getNestResponse.Devices.Thermostats.First().Value.has_leaf.ShouldEqual(false);
            getNestResponse.Devices.Thermostats.First().Value.device_id.ShouldEqual("AqU5hBHtd0T1xZL4lETxUr61kmpWI1kB");
            getNestResponse.Devices.Thermostats.First().Value.name.ShouldEqual("Hallway");
            getNestResponse.Devices.Thermostats.First().Value.can_heat.ShouldEqual(true);
            getNestResponse.Devices.Thermostats.First().Value.can_cool.ShouldEqual(false);
            getNestResponse.Devices.Thermostats.First().Value.hvac_mode.ShouldEqual("heat");
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_c.ShouldEqual(20);
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_f.ShouldEqual(68);
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_high_c.ShouldEqual(24.0);
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_high_f.ShouldEqual(75);
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_low_c.ShouldEqual(20.0);
            getNestResponse.Devices.Thermostats.First().Value.target_temperature_low_f.ShouldEqual(68);
            getNestResponse.Devices.Thermostats.First().Value.ambient_temperature_c.ShouldEqual(20.0);
            getNestResponse.Devices.Thermostats.First().Value.ambient_temperature_f.ShouldEqual(69);
            getNestResponse.Devices.Thermostats.First().Value.away_temperature_high_c.ShouldEqual(24.0);
            getNestResponse.Devices.Thermostats.First().Value.away_temperature_high_f.ShouldEqual(76);
            getNestResponse.Devices.Thermostats.First().Value.away_temperature_low_c.ShouldEqual(12.0);
            getNestResponse.Devices.Thermostats.First().Value.away_temperature_low_f.ShouldEqual(54);
            getNestResponse.Devices.Thermostats.First().Value.structure_id.ShouldEqual("_saUDvAzTFsgxJXmZSyDbMIrQzMlEeWO8PczmpAdzPHTFZ37j49K3w");
            getNestResponse.Devices.Thermostats.First().Value.fan_timer_active.ShouldEqual(false);
            getNestResponse.Devices.Thermostats.First().Value.name_long.ShouldEqual("Hallway Thermostat");
            getNestResponse.Devices.Thermostats.First().Value.is_online.ShouldEqual(true);
        }
    }
}
