using System.Collections.Generic;
using Job.Roles.Dto;

namespace Job.Web.Models.Admin.AdminRoles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
