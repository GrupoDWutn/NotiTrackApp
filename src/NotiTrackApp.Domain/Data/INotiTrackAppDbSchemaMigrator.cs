using System.Threading.Tasks;

namespace NotiTrackApp.Data;

public interface INotiTrackAppDbSchemaMigrator
{
    Task MigrateAsync();
}
