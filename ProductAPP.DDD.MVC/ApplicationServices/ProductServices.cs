using ProductAPP.DDD.Domain.Entities;
using ProductAPP.DDD.Domain.Repositories;
using ProductAPP.DDD.Domain.Value_Objects.Product;
using ProductAPP.DDD.MVC.Commands;
using ProductAPP.DDD.MVC.Queries;

namespace ProductAPP.DDD.MVC.ApplicationServices
{
    public class ProductServices
    {
        private readonly IProductRepository productRepository;
        private readonly ProductQueries productQueries;

        public ProductServices(IProductRepository productRepository, 
            ProductQueries productQueries
            )
        {
            this.productRepository = productRepository;
            this.productQueries = productQueries;
        }
        public async Task HandleCommand(CreateProductCommand command) 
        {
            var product = new Product();
            product.SetName(ProductName.Create(command.Name));
            product.SetPrice(ProductPrice.Create(command.Price));
            product.SetStock(ProductStock.Create(command.Stock));
            product.SetDescription(ProductDescription.Create(command.Description));
            await productRepository.AddProduct(product);
        }
        public async Task<Product> GetProduct(Guid id) 
        {
            return await productQueries.GetProductById(id);
        }
        public async Task<List<Product>> GetAllProducts() 
        {
            return await productQueries.GetProductsAsync();
        }
    }
}
