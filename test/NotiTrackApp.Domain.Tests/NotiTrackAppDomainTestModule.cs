using NotiTrackApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NotiTrackApp;

[DependsOn(
    typeof(NotiTrackAppEntityFrameworkCoreTestModule)
    )]
public class NotiTrackAppDomainTestModule : AbpModule
{

}
