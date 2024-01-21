using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace SmartApp.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class SmartAppDbContext : SmartAppDbContextBase<SmartAppDbContext>
{
    public SmartAppDbContext(DbContextOptions<SmartAppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Both);

        base.OnModelCreating(builder);
    }
}
