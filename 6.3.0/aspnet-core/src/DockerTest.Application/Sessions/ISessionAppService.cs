using System.Threading.Tasks;
using Abp.Application.Services;
using DockerTest.Sessions.Dto;

namespace DockerTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
