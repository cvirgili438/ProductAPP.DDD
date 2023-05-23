using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Value_Objects.Product
{
    public record ProductId
    {
        public Guid Value { get; private set; }
        internal ProductId(Guid value) 
        {
            this.Value = value;
        }
        public static ProductId Create(Guid value) 
        {
            return new ProductId(value);
        }
        public static implicit operator Guid(ProductId productId) 
        {
            return productId.Value;
        }
    }
}
