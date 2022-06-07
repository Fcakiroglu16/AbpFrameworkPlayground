using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace AbpFrameworkPlayground.Products;

public class ProductAppService : AbpFrameworkPlaygroundAppService, IProductService
{
    private readonly IRepository<Product, Guid> _repository;

    public ProductAppService(IRepository<Product, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var quearyable = await _repository.WithDetailsAsync(x => x.Category);

        quearyable = quearyable.Skip(input.SkipCount).Take(input.MaxResultCount).OrderBy(input.Sorting ?? nameof
            (Product.Name));

        var products = await AsyncExecuter.ToListAsync(quearyable);

        var count = await _repository.GetCountAsync();

        return new PagedResultDto<ProductDto>(count, ObjectMapper.Map<List<Product>, List<ProductDto>>(products));
    }
}