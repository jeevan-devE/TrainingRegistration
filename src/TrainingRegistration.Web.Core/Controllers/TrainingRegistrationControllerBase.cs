using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TrainingRegistration.Controllers
{
    public abstract class TrainingRegistrationControllerBase: AbpController
    {
        protected TrainingRegistrationControllerBase()
        {
            LocalizationSourceName = TrainingRegistrationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
