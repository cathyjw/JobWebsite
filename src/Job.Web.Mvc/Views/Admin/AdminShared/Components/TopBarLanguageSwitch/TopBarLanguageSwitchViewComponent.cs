﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Abp.Localization;

namespace Job.Web.Views.Admin.AdminShared.Components.TopBarLanguageSwitch
{
    public class TopBarLanguageSwitchViewComponent : JobViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public TopBarLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public IViewComponentResult Invoke()
        {
            var model = new TopBarLanguageSwitchViewModel
            {
                CurrentLanguage = _languageManager.CurrentLanguage,
                Languages = _languageManager.GetLanguages().Where(l => !l.IsDisabled).ToList()
            };

            return View("~/Views/Admin/AdminShared/Components/TopBarLanguageSwitch/Default.cshtml", model);
        }
    }
}
