using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SmartApp;

[Dependency(ReplaceServices = true)]
public class SmartAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SmartApp";
}
