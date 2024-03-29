using System.Collections.Generic;
using Job.Roles.Dto;
using Job.Users.Dto;

namespace Job.Web.Models.Admin.AdminUsers
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
