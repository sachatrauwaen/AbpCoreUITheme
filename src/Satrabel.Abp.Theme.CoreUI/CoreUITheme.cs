using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Satrabel.Abp.Theme.CoreUI
{
    [ThemeName(Name)]
    public class CoreUITheme : ITheme, ITransientDependency
    {
        public const string Name = "CoreUI";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case "ClientApplication":
                    return "~/Themes/CoreUI/Layouts/ClientApplication.cshtml";
                case StandardLayouts.Application:
                    return "~/Themes/CoreUI/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/CoreUI/Layouts/Account.cshtml";
                case StandardLayouts.Public:
                    return "~/Themes/CoreUI/Layouts/Application.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/CoreUI/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/CoreUI/Layouts/Application.cshtml" : null;
            }
        }
    }
}
