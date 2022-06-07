using System;
using AbpFrameworkPlayground.Categories;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpFrameworkPlayground.Products;

public class Product:FullAuditedAggregateRoot<Guid>
{
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsFreeCargo { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ProductStockState ProductStock { get; set; }
    
}