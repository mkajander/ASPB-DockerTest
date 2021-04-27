using Abp.AutoMapper;
using Abp.BackgroundJobs;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DockerTest.Authorization;

namespace DockerTest
{
    [DependsOn(
        typeof(DockerTestCoreModule),
        typeof(AbpAutoMapperModule))]
    public class DockerTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.Authorization.Providers.Add<DockerTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DockerTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
