using System.Threading.Tasks;
using NestPlay.Contracts;
using NestPlay.Queries;
using Newtonsoft.Json;

namespace NestPlay.Services
{
    public class GetNestResponseService : IGetNestResponseService
    {
        private readonly IGetDeviceQuery _getDeviceQuery;

        public GetNestResponseService(IGetDeviceQuery getDeviceQuery)
        {
            _getDeviceQuery = getDeviceQuery;
        }

        public GetNestResponse Get()
        {
            var deviceData = _getDeviceQuery.Execute();

            return new GetNestResponse()
            {
                Devices = JsonConvert.DeserializeObject<Device>(deviceData)
            };
        }

        public async Task<GetNestResponse> GetAsync()
        {
            
            return await Task.Run(() =>
                new GetNestResponse
                {
                    Devices = JsonConvert.DeserializeObject<Device>(_getDeviceQuery.Execute())
                });
        }
    }
}
