using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Satrabel.Abp.Theme.CoreUI.Bundling
{
    public class CoreUIThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            //context.Files.Add("/themes/coreui/bootstrap/js/popper.min.js");
            //context.Files.Add("/themes/coreui/bootstrap/js/bootstrap.min.js");
            context.Files.Add("/themes/coreui/js/coreui.min.js");
            context.Files.Add("/themes/coreui/layout.js");
            context.Files.ReplaceOne("/libs/bootstrap/js/bootstrap.bundle.js",
                "/themes/coreui/bootstrap/js/bootstrap.min.js");
            context.Files.InsertBefore("/themes/coreui/bootstrap/js/bootstrap.min.js",
                "/themes/coreui/bootstrap/js/popper.min.js");
        }
    }
}