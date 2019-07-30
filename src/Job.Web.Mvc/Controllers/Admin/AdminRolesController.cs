using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Authorization;
using Job.Controllers;
using Job.Roles;
using Job.Roles.Dto;
using Job.Web.Models.Admin.AdminRoles;

namespace Job.Web.Controllers.Admin
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class AdminRolesController : JobControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public AdminRolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        public async Task<IActionResult> Index()
        {
            var roles = (await _roleAppService.GetRolesAsync(new GetRolesInput())).Items;
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Roles = roles,
                Permissions = permissions
            };

            return View("~/Views/Admin/AdminRoles/Index.cshtml",model);
        }

        public async Task<ActionResult> EditRoleModal(int roleId)
        {
            var output = await _roleAppService.GetRoleForEdit(new EntityDto(roleId));
            var model = new EditRoleModalViewModel(output);

            return View("~/Views/Admin/AdminRoles/_EditRoleModal.cshtml", model);
        }
    }
}
