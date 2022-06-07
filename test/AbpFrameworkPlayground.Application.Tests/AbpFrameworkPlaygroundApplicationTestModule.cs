using Volo.Abp.Modularity;

namespace AbpFrameworkPlayground;

[DependsOn(
    typeof(AbpFrameworkPlaygroundApplicationModule),
    typeof(AbpFrameworkPlaygroundDomainTestModule)
    )]
public class AbpFrameworkPlaygroundApplicationTestModule : AbpModule
{

}
