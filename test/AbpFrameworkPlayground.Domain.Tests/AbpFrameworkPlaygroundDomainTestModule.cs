using AbpFrameworkPlayground.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpFrameworkPlayground;

[DependsOn(
    typeof(AbpFrameworkPlaygroundEntityFrameworkCoreTestModule)
    )]
public class AbpFrameworkPlaygroundDomainTestModule : AbpModule
{

}
