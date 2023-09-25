using Volo.Abp.Settings;

namespace NotiTrackApp.Settings;

public class NotiTrackAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NotiTrackAppSettings.MySetting1));
    }
}
