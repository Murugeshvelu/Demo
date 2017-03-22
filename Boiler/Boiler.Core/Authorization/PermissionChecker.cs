using Abp.Authorization;
using Boiler.Authorization.Roles;
using Boiler.MultiTenancy;
using Boiler.Users;

namespace Boiler.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
