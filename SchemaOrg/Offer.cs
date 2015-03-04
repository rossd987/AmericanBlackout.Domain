using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain.SchemaOrg
{
    public class Offer: Redis.RedisItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ItemAvailability Availability { get; set; }
        public Uri URL { get; set; }
        public DateTime VaildFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
