using Abp.Authorization;
using GovermentSecuritySystemApp.Authorization.Roles;
using GovermentSecuritySystemApp.Authorization.Users;

namespace GovermentSecuritySystemApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
