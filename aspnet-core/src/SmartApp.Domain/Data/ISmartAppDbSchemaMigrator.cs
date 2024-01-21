using System.Threading.Tasks;

namespace SmartApp.Data;

public interface ISmartAppDbSchemaMigrator
{
    Task MigrateAsync();
}
