using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Value_Objects.Product
{
    public record ProductStock
    {
        public int Value { get; init; }
        internal ProductStock(int value) 
        {
            this.Value = value;
        }
        private static void Validate (int value ) 
        {
            if(value < 0) 
            {
                throw new ArgumentOutOfRangeException("value cannot be less than 0 ");
            }
        }
        public static ProductStock Create (int value) 
        {
            Validate(value);
            return new ProductStock(value);
        }
    }
}
