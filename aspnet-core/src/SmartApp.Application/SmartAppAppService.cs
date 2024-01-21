using SmartApp.Localization;
using Volo.Abp.Application.Services;

namespace SmartApp;

/* Inherit your application services from this class.
 */
public abstract class SmartAppAppService : ApplicationService
{
    protected SmartAppAppService()
    {
        LocalizationResource = typeof(SmartAppResource);
    }
}
