using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NotiTrackApp;

[Dependency(ReplaceServices = true)]
public class NotiTrackAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NotiTrackApp";
}
