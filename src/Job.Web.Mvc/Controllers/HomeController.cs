using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Job.Web.Models;
using Job.Web.Views.Admin.AdminShared.Components.TenantChange;
using Microsoft.AspNetCore.Mvc;

namespace Job.Web.Controllers
{
    public class HomeController : AbpController
    {
        public ActionResult Index()
        {
			var movie = new HomeModel() { Id = 1, Title = "Developer"};
			
            return View(movie);
        }
    }
}