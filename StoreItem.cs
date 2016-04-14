using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;
using AmericanBlackout.Domain.Redis;

namespace AmericanBlackout.Domain
{
    public class StoreItem : RedisItem
    {
        public string Image { get; set; }
        public decimal PriceHigh { get; set; }
        public decimal PriceLow { get; set; }
        public string Title { get; set; }
        
        [AllowHtml]
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Priority { get; set; }

        [AllowHtml]
        public string PayPalCode { get; set; }
    }
}
