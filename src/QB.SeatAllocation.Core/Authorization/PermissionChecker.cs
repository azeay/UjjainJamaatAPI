using Abp.Authorization;
using QB.SeatAllocation.Authorization.Roles;
using QB.SeatAllocation.Authorization.Users;

namespace QB.SeatAllocation.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
