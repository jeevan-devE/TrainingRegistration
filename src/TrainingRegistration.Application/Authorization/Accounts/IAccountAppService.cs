using System.Threading.Tasks;
using Abp.Application.Services;
using TrainingRegistration.Authorization.Accounts.Dto;

namespace TrainingRegistration.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
