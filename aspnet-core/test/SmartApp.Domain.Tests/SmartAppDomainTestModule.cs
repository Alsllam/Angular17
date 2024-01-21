using SmartApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SmartApp;

[DependsOn(
    typeof(SmartAppEntityFrameworkCoreTestModule)
    )]
public class SmartAppDomainTestModule : AbpModule
{

}
