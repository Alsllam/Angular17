using SmartApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SmartApp.Permissions;

public class SmartAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SmartAppPermissions.GroupName);

        myGroup.AddPermission(SmartAppPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(SmartAppPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(SmartAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SmartAppResource>(name);
    }
}
