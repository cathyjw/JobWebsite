using Abp.AutoMapper;
using Job.Sessions.Dto;

namespace Job.Web.Views.Admin.AdminShared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
