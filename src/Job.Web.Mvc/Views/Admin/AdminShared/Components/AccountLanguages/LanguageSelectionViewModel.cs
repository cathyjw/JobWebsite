using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Abp.Localization;

namespace Job.Web.Views.Admin.AdminShared.Components.AccountLanguages
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public PathString CurrentUrl { get; set; }
    }
}
