using SmartApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace SmartApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(SmartAppEntityFrameworkCoreModule),
    typeof(SmartAppApplicationContractsModule)
)]
public class SmartAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "SmartApp:"; });
    }
}
