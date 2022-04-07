using Abp.Authorization;
using TrainingRegistration.Authorization.Roles;
using TrainingRegistration.Authorization.Users;

namespace TrainingRegistration.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
