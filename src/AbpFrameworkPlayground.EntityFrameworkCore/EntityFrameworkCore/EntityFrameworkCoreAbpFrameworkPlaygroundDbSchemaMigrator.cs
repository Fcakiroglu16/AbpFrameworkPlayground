using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpFrameworkPlayground.Data;
using Volo.Abp.DependencyInjection;

namespace AbpFrameworkPlayground.EntityFrameworkCore;

public class EntityFrameworkCoreAbpFrameworkPlaygroundDbSchemaMigrator
    : IAbpFrameworkPlaygroundDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpFrameworkPlaygroundDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpFrameworkPlaygroundDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpFrameworkPlaygroundDbContext>()
            .Database
            .MigrateAsync();
    }
}
