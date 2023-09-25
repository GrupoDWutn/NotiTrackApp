using NotiTrackApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NotiTrackApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NotiTrackAppEntityFrameworkCoreModule),
    typeof(NotiTrackAppApplicationContractsModule)
    )]
public class NotiTrackAppDbMigratorModule : AbpModule
{
}
