﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpFrameworkPlayground;

[Dependency(ReplaceServices = true)]
public class AbpFrameworkPlaygroundBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpFrameworkPlayground";
}
