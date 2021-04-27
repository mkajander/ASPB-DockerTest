using System.Threading.Tasks;
using DockerTest.Configuration.Dto;

namespace DockerTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
