using System.Threading.Tasks;
using GovermentSecuritySystemApp.Models.TokenAuth;
using GovermentSecuritySystemApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace GovermentSecuritySystemApp.Web.Tests.Controllers
{
    public class HomeController_Tests: GovermentSecuritySystemAppWebTestBase
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