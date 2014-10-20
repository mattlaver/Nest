using System.Threading.Tasks;
using NestPlay.Contracts;

namespace NestPlay.Services
{
    public interface IGetNestResponseService
    {
        GetNestResponse Get();
        Task<GetNestResponse> GetAsync();
    }
}