using AbpFrameworkPlayground.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpFrameworkPlayground.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpFrameworkPlaygroundEntityFrameworkCoreModule),
    typeof(AbpFrameworkPlaygroundApplicationContractsModule)
    )]
public class AbpFrameworkPlaygroundDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
