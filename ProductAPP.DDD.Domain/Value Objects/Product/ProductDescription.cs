using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPP.DDD.Domain.Value_Objects.Product
{
    public record ProductDescription
    {
        public string Value { get; init; }
        public ProductDescription(string value)
        {
            this.Value = value;
        }
        public static ProductDescription Create(string value) 
        {
            Validate(value);
            return new ProductDescription(value);
        }
        private static void Validate( string value) 
        {
            if (value.Length >400) 
            {
                throw new ArgumentException("The descriptions cannot have more than 400 character");
            }
        }
    }
}
