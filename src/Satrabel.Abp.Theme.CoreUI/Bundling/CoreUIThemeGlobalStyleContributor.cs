using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Satrabel.Abp.Theme.CoreUI.Bundling
{
    public class CoreUIThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            //context.Files.Add("/themes/coreui/font-awesome/css/fontawesome.min.css");
            context.Files.Add("/themes/coreui/css/style.css");
            context.Files.Add("/themes/coreui/pace-progress/css/pace.min.css");
            context.Files.Add("/themes/coreui/layout.css");
            context.Files.Remove("/libs/bootstrap/css/bootstrap.css");
        }
    }
}
