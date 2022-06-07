using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpFrameworkPlayground.Data;

/* This is used if database provider does't define
 * IAbpFrameworkPlaygroundDbSchemaMigrator implementation.
 */
public class NullAbpFrameworkPlaygroundDbSchemaMigrator : IAbpFrameworkPlaygroundDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
