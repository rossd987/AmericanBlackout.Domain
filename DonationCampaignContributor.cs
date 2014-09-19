using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmericanBlackout.Domain.Redis;

namespace AmericanBlackout.Domain
{
    public class DonationCampaignContributor : RedisItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public long DonationCampaign { get; set; }
        public DateTime Date { get; set; }
    }
}
