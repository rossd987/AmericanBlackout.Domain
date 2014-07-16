using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmericanBlackout.Domain.Redis;

namespace AmericanBlackout.Domain
{
    public class Band : RedisItem
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
    }
}
