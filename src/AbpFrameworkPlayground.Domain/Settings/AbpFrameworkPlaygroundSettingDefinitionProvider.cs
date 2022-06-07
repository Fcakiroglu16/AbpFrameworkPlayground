using Volo.Abp.Settings;

namespace AbpFrameworkPlayground.Settings;

public class AbpFrameworkPlaygroundSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpFrameworkPlaygroundSettings.MySetting1));
    }
}
