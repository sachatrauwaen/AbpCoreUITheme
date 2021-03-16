using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Satrabel.Abp.Theme.CoreUI.Themes.CoreUI.Components.Brand
{
    public class MainNavbarBrandViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/CoreUI/Components/Brand/Default.cshtml");
        }
    }
}
