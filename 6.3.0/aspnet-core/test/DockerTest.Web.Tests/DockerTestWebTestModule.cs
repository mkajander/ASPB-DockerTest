using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DockerTest.EntityFrameworkCore;
using DockerTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DockerTest.Web.Tests
{
    [DependsOn(
        typeof(DockerTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DockerTestWebTestModule : AbpModule
    {
        public DockerTestWebTestModule(DockerTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DockerTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DockerTestWebMvcModule).Assembly);
        }
    }
}