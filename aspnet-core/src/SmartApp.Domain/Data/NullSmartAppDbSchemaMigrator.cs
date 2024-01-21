using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SmartApp.Data;

/* This is used if database provider does't define
 * ISmartAppDbSchemaMigrator implementation.
 */
public class NullSmartAppDbSchemaMigrator : ISmartAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
