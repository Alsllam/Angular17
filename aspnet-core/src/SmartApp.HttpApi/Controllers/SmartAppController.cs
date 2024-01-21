using SmartApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SmartApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SmartAppController : AbpControllerBase
{
    protected SmartAppController()
    {
        LocalizationResource = typeof(SmartAppResource);
    }
}
