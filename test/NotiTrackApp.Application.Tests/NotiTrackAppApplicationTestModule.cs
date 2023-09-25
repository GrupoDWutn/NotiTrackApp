using Volo.Abp.Modularity;

namespace NotiTrackApp;

[DependsOn(
    typeof(NotiTrackAppApplicationModule),
    typeof(NotiTrackAppDomainTestModule)
    )]
public class NotiTrackAppApplicationTestModule : AbpModule
{

}
