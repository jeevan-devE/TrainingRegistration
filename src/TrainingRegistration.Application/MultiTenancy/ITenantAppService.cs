using Abp.Application.Services;
using TrainingRegistration.MultiTenancy.Dto;

namespace TrainingRegistration.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

