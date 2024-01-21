using Volo.Abp.Settings;

namespace SmartApp.Settings;

public class SmartAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SmartAppSettings.MySetting1));
    }
}
