using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NotiTrackApp.Data;

/* This is used if database provider does't define
 * INotiTrackAppDbSchemaMigrator implementation.
 */
public class NullNotiTrackAppDbSchemaMigrator : INotiTrackAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
