using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmericanBlackout.Domain.Redis;
using System.Web.Mvc;

namespace AmericanBlackout.Domain
{
    public class NewsItem : RedisItem
    {
        [AllowHtml]
        public string Article { get; set; }
        public DateTime PostDate { get; set; }
        public string Title { get; set; }
    }
}
