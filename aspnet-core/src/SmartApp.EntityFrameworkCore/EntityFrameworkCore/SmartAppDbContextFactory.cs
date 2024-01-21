using Microsoft.EntityFrameworkCore;

namespace SmartApp.EntityFrameworkCore;

public class SmartAppDbContextFactory :
    SmartAppDbContextFactoryBase<SmartAppDbContext>
{
    protected override SmartAppDbContext CreateDbContext(
        DbContextOptions<SmartAppDbContext> dbContextOptions)
    {
        return new SmartAppDbContext(dbContextOptions);
    }
}
