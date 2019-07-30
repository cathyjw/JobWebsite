using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Authorization;
using Job.Controllers;
using Job.MultiTenancy;
using Job.MultiTenancy.Dto;

namespace Job.Web.Controllers.Admin
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class AdminTenantsController : JobControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public AdminTenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAll(new PagedTenantResultRequestDto { MaxResultCount = int.MaxValue }); // Paging not implemented yet
            return View("~/Views/Admin/AdminTenants/Index.cshtml", output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.Get(new EntityDto(tenantId));
            return View("~/Views/Admin/AdminTenants/_EditTenantModal.cshtml", tenantDto);
        }
    }
}
