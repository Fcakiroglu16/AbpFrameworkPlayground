using System;
using System.Collections.Generic;
using System.Text;
using AbpFrameworkPlayground.Localization;
using Volo.Abp.Application.Services;

namespace AbpFrameworkPlayground;

/* Inherit your application services from this class.
 */
public abstract class AbpFrameworkPlaygroundAppService : ApplicationService
{
    protected AbpFrameworkPlaygroundAppService()
    {
        LocalizationResource = typeof(AbpFrameworkPlaygroundResource);
    }
}
