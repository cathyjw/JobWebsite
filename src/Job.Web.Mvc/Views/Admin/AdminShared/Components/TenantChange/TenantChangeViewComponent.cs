using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AutoMapper;
using Job.Sessions;

namespace Job.Web.Views.Admin.AdminShared.Components.TenantChange
{
    public class TenantChangeViewComponent : JobViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TenantChangeViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View("~/Views/Admin/AdminShared/Components/TenantChange/Default.cshtml", model);
        }
    }
}
