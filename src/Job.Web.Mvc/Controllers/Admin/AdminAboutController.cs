using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Controllers;

namespace Job.Web.Controllers.Admin
{
    [AbpMvcAuthorize]
    public class AdminAboutController : JobControllerBase
    {
        public ActionResult Index()
        {
            return View("~/Views/Admin/AdminAbout/Index.cshtml");
        }
	}
}
