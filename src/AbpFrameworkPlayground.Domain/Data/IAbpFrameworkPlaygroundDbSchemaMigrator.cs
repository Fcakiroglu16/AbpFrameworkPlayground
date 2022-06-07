using System.Threading.Tasks;

namespace AbpFrameworkPlayground.Data;

public interface IAbpFrameworkPlaygroundDbSchemaMigrator
{
    Task MigrateAsync();
}
