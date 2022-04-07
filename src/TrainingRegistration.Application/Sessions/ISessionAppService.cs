using System.Threading.Tasks;
using Abp.Application.Services;
using TrainingRegistration.Sessions.Dto;

namespace TrainingRegistration.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
