using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpFrameworkPlayground.Pages;

public class Index_Tests : AbpFrameworkPlaygroundWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
