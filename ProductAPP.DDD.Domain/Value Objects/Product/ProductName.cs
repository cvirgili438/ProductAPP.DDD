using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Value_Objects.Product
{
    public record ProductName
    {
        public string Value { get; init; }

        internal ProductName(string value) 
        {
            this.Value = value;
        }
        public static ProductName Create(string value) 
        {
            Validate(value);
            return new ProductName(value);
        }
        private static void Validate(string test) 
        {
            if (test.Length <= 0) 
            {
                throw new ArgumentException("String length has to be more than 0 ");
            }
        }
    }
}
