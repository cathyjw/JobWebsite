using System.Collections.Generic;
using Job.Roles.Dto;

namespace Job.Web.Models.Admin.AdminCommon
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}