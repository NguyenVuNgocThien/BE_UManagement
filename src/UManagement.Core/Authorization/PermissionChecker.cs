using Abp.Authorization;
using UManagement.Authorization.Roles;
using UManagement.Authorization.Users;

namespace UManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
