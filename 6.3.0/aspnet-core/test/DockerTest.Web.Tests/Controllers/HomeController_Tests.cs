using System.Threading.Tasks;
using DockerTest.Models.TokenAuth;
using DockerTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace DockerTest.Web.Tests.Controllers
{
    public class HomeController_Tests: DockerTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}