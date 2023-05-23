using ProductAPP.DDD.Domain.Value_Objects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Entities
{
    public class Product
    {
        public Guid? Id { get; init; }
        public ProductName Name { get; private set; }
        public ProductPrice Price { get; private set; }
        public ProductStock Stock { get; private set; }
        public ProductDescription Description { get; private set; }

        //public Product(Guid id)
        //{
        //    this.Id = id;
        //}
        public void SetName(ProductName name) 
        {
            Name=name;
        }
        public void SetPrice(ProductPrice price) 
        {
            Price=price;
        }
        public void SetStock(ProductStock stock) 
        {
            Stock=stock;
        }
        public void SetDescription(ProductDescription description) 
        { 
            Description=description;
        }

    }
}
