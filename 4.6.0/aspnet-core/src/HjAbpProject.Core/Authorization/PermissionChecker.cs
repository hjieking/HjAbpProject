using Abp.Authorization;
using HjAbpProject.Authorization.Roles;
using HjAbpProject.Authorization.Users;

namespace HjAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
