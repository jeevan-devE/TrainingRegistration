using System.Threading.Tasks;
using TrainingRegistration.Models.TokenAuth;
using TrainingRegistration.Web.Controllers;
using Shouldly;
using Xunit;

namespace TrainingRegistration.Web.Tests.Controllers
{
    public class HomeController_Tests: TrainingRegistrationWebTestBase
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