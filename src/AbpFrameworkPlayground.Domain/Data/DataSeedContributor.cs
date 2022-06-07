using System;
using System.Threading.Tasks;
using AbpFrameworkPlayground.Categories;
using AbpFrameworkPlayground.Products;
using IdentityModel;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpFrameworkPlayground.Data;

public class DataSeedContributor:IDataSeedContributor,ITransientDependency
{
    private readonly  IRepository<Product,Guid> _productRepository;
    private readonly IRepository<Category, Guid> _categoryRepository;

    public DataSeedContributor(IRepository<Product, Guid> productRepository, IRepository<Category, Guid> categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {

        if (await _categoryRepository.CountAsync() == 0)
        {
            var monitors = new Category() { Name = "Monitors" };

            await _categoryRepository.InsertAsync(monitors);

            var monitor1 = new Product
            {

                Category = monitors,

                Name = "monitor 1",
                Price = 100,
                IsFreeCargo = false,
                ReleaseDate = DateTime.Now,
                ProductStock = ProductStockState.PreOrder,

            };

            var monitor2 = new Product
            {

                Category = monitors,

                Name = "monitor 1",
                Price = 100,
                IsFreeCargo = false,
                ReleaseDate = DateTime.Now,
                ProductStock = ProductStockState.PreOrder,

            };


            await _productRepository.InsertManyAsync(new[] { monitor1, monitor2 });
        }
            
            
          
    }
}