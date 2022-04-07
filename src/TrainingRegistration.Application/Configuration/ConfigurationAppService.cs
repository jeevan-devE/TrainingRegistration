using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TrainingRegistration.Configuration.Dto;

namespace TrainingRegistration.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TrainingRegistrationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
