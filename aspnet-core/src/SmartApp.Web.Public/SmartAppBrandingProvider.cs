using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SmartApp.Web.Public;

[Dependency(ReplaceServices = true)]
public class SmartAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SmartApp";
}
