using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NotiTrackApp.Data;
using Volo.Abp.DependencyInjection;

namespace NotiTrackApp.EntityFrameworkCore;

public class EntityFrameworkCoreNotiTrackAppDbSchemaMigrator
    : INotiTrackAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNotiTrackAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NotiTrackAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NotiTrackAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
