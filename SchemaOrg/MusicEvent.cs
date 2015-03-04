using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain.SchemaOrg
{
    public class MusicEvent : Redis.RedisItem
    {
        public string Name { get; set; }
        public Uri Image { get; set; }
        public Uri URL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DoorTime { get; set; }
        public DateTime EndDate { get; set; }
        public long LocationId { get; set; }
        public List<long> OfferIds { get; set; }
        public List<long> PerformerIds { get; set; }
        public string AgeRange { get; set; }
    }
}
