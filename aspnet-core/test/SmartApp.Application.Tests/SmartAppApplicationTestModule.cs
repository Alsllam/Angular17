using Volo.Abp.Modularity;

namespace SmartApp;

[DependsOn(
    typeof(SmartAppApplicationModule),
    typeof(SmartAppDomainTestModule)
    )]
public class SmartAppApplicationTestModule : AbpModule
{

}
