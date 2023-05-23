using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Value_Objects.Product
{
    public record ProductPrice
    {
        public decimal Value { get; set; }

        internal ProductPrice(decimal value)
        {
            this.Value = value;
        }
        private static void Validate(decimal value) 
        {
            if (value <= 0) 
            {
                throw new ArgumentException("The value has to be more than 0 ");
            }
        }
        public static ProductPrice Create(decimal value) 
        {
            Validate(value);
            return new ProductPrice(value); 
        }
    }
}
