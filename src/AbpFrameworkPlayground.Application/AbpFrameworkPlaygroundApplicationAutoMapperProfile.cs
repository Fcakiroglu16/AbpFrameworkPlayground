using AbpFrameworkPlayground.Products;
using AutoMapper;

namespace AbpFrameworkPlayground;

public class AbpFrameworkPlaygroundApplicationAutoMapperProfile : Profile
{
    public AbpFrameworkPlaygroundApplicationAutoMapperProfile()
    {

        CreateMap<Product, ProductDto>().ReverseMap();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
