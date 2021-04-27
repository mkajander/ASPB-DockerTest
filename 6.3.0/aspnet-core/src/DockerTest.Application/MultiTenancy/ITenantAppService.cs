using Abp.Application.Services;
using DockerTest.MultiTenancy.Dto;

namespace DockerTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

