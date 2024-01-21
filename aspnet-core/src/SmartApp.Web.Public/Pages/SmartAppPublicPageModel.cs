using SmartApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SmartApp.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class SmartAppPublicPageModel : AbpPageModel
{
    protected SmartAppPublicPageModel()
    {
        LocalizationResourceType = typeof(SmartAppResource);
    }
}
