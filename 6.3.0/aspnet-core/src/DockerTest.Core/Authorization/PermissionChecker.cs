using Abp.Authorization;
using DockerTest.Authorization.Roles;
using DockerTest.Authorization.Users;

namespace DockerTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
