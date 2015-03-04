using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;
using AmericanBlackout.Domain.Redis;

namespace AmericanBlackout.Domain
{
    public class DonationCampaign : RedisItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal TotalDonations { get; set; }
        public int NumberOfDonations { get; set; }
        public decimal AverageDonation { get; set; }
        public List<long> TopContributors { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        [AllowHtml]
        public string PaypalButton { get; set; }
    }
}
