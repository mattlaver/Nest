using FirebaseSharp.Portable;

namespace NestPlay.Queries
{
    internal class GetDeviceQuery : IGetDeviceQuery
    {
        private readonly string _accessToken;

        public GetDeviceQuery(string accessToken)
        {
            _accessToken = accessToken;
        }

        public string Execute()
        {
            var firebaseClient = new Firebase("https://developer-api.nest.com", _accessToken);
            return firebaseClient.Get("devices");            
        }
    }
}
