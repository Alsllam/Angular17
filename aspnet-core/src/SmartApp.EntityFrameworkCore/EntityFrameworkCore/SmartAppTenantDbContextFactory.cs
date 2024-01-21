using Microsoft.EntityFrameworkCore;

namespace SmartApp.EntityFrameworkCore;

public class SmartAppTenantDbContextFactory :
    SmartAppDbContextFactoryBase<SmartAppTenantDbContext>
{
    protected override SmartAppTenantDbContext CreateDbContext(
        DbContextOptions<SmartAppTenantDbContext> dbContextOptions)
    {
        return new SmartAppTenantDbContext(dbContextOptions);
    }
}
