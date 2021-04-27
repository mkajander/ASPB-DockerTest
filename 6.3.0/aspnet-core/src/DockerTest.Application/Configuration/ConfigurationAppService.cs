using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DockerTest.Configuration.Dto;

namespace DockerTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DockerTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
