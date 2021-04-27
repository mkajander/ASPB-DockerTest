using System.Threading.Tasks;
using Abp.Application.Services;
using DockerTest.Authorization.Accounts.Dto;

namespace DockerTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
