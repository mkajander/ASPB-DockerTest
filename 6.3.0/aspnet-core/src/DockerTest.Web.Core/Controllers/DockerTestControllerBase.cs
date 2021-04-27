using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DockerTest.Controllers
{
    public abstract class DockerTestControllerBase: AbpController
    {
        protected DockerTestControllerBase()
        {
            LocalizationSourceName = DockerTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
