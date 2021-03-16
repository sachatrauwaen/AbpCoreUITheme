using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Satrabel.Abp.Theme.CoreUI.Themes.CoreUI.Components.MainNavbar
{
    public class MainNavbarViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/CoreUI/Components/MainNavbar/Default.cshtml");
        }
    }
}
