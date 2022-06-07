using AbpFrameworkPlayground.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpFrameworkPlayground.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpFrameworkPlaygroundPageModel : AbpPageModel
{
    protected AbpFrameworkPlaygroundPageModel()
    {
        LocalizationResourceType = typeof(AbpFrameworkPlaygroundResource);
    }
}
