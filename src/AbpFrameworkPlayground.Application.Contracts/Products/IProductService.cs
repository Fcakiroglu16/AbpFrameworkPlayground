using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace AbpFrameworkPlayground.Products;

public interface IProductService
{
    Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
}