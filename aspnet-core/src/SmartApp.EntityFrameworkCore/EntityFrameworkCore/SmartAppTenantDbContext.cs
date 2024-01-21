using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace SmartApp.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class SmartAppTenantDbContext : SmartAppDbContextBase<SmartAppTenantDbContext>
{
    public SmartAppTenantDbContext(DbContextOptions<SmartAppTenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Tenant);

        base.OnModelCreating(builder);
    }
}
