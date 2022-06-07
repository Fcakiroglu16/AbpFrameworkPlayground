using AbpFrameworkPlayground.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpFrameworkPlayground.Permissions;

public class AbpFrameworkPlaygroundPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpFrameworkPlaygroundPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpFrameworkPlaygroundPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpFrameworkPlaygroundResource>(name);
    }
}
