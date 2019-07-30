using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Authorization;
using Job.Controllers;
using Job.Users;
using Job.Web.Models.Admin.AdminUsers;
using Job.Users.Dto;

namespace Job.Web.Controllers.Admin
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class AdminUsersController : JobControllerBase
    {
        private readonly IUserAppService _userAppService;

        public AdminUsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var users = (await _userAppService.GetAll(new PagedUserResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles
            };
            return View("~/Views/Admin/AdminUsers/Index.cshtml", model);
        }

        public async Task<ActionResult> EditUserModal(long userId)
        {
            var user = await _userAppService.Get(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return View("~/Views/Admin/AdminUsers/_EditUserModal.cshtml", model);
        }
    }
}
