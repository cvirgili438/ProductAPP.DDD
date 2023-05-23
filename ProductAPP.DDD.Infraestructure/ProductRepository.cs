using Microsoft.EntityFrameworkCore;
using ProductAPP.DDD.Domain.Entities;
using ProductAPP.DDD.Domain.Repositories;
using ProductAPP.DDD.Domain.Value_Objects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Infraestructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext db;

        public ProductRepository(DatabaseContext db)
        {
            this.db = db;
        }
        public async Task AddProduct(Product product)
        {
            await db.AddAsync(product);
            await db.SaveChangesAsync();
        }

        public async Task<List<Product>> AllProduct()
        {
            return await db.Products.ToListAsync();
        }

        public async Task<Product> GetproductById(ProductId id)
        {
            return await db.Products.FindAsync((Guid)id);  
        }
    }
}
