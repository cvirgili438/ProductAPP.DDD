using ProductAPP.DDD.Domain.Entities;
using ProductAPP.DDD.Domain.Repositories;
using ProductAPP.DDD.Domain.Value_Objects.Product;

namespace ProductAPP.DDD.MVC.Queries
{
    public class ProductQueries
    {
        private readonly IProductRepository productRepository;

        public ProductQueries(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> GetProductById(Guid id) 
        {
            var response = await productRepository.GetproductById(ProductId.Create(id));
            return response;
        }
        public async Task<List<Product>> GetProductsAsync() 
        {
            var response = await productRepository.AllProduct();
            return response;
        }

    }
}
