using NestPlay.Contracts;
using NestPlay.Queries;
using NestPlay.Services;

namespace NestPlay
{
    public class Nest
    {
        private readonly string _accessToken;
        private readonly GetNestResponseService _getNestResponseService;

        public Nest(string accessToken)
        {
            _accessToken = accessToken;
            _getNestResponseService = new GetNestResponseService(new GetDeviceQuery(_accessToken));
        }

        public GetNestResponse Get()
        {
            return _getNestResponseService.Get();
        }
    }
}
