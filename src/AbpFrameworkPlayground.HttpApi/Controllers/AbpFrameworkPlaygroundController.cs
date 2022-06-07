using AbpFrameworkPlayground.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpFrameworkPlayground.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpFrameworkPlaygroundController : AbpControllerBase
{
    protected AbpFrameworkPlaygroundController()
    {
        LocalizationResource = typeof(AbpFrameworkPlaygroundResource);
    }
}
