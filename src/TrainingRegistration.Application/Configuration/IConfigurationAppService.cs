using System.Threading.Tasks;
using TrainingRegistration.Configuration.Dto;

namespace TrainingRegistration.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
