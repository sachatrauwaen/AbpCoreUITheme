using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Satrabel.Abp.Theme.CoreUI;
using Satrabel.Abp.Theme.CoreUI.Themes.CoreUI.Components.Toolbar.LanguageSwitch;
using Satrabel.Abp.Theme.CoreUI.Themes.CoreUI.Components.Toolbar.UserMenu;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Localization;
using Volo.Abp.Users;

namespace Satrabel.Abp.Theme.CoreUI.Toolbars
{
    public class CoreUIThemeMainTopToolbarContributor : IToolbarContributor
    {
        public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != StandardToolbars.Main)
            {
                return;
            }

            if (!(context.Theme is CoreUITheme))
            {
                return;
            }

            if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
            }

            var languageProvider = context.ServiceProvider.GetService<ILanguageProvider>();

            //TODO: This duplicates GetLanguages() usage. Can we eleminate this?
            var languages = await languageProvider.GetLanguagesAsync();
            if (languages.Count > 1)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));
            }

            
        }
    }
}
