using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DockerTest.MultiTenancy;

namespace DockerTest.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
