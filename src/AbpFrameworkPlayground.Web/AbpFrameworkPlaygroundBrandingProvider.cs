using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpFrameworkPlayground.Web;

[Dependency(ReplaceServices = true)]
public class AbpFrameworkPlaygroundBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpFrameworkPlayground";
}
