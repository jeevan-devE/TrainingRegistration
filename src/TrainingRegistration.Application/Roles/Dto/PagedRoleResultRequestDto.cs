using Abp.Application.Services.Dto;

namespace TrainingRegistration.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

