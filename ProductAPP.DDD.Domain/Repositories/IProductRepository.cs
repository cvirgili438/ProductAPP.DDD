using ProductAPP.DDD.Domain.Entities;
using ProductAPP.DDD.Domain.Value_Objects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetproductById(ProductId id);
        Task AddProduct(Product product);
        // Task AddStock(ProductStock productStock, Product product);
        Task<List<Product>> AllProduct();
    }
}
