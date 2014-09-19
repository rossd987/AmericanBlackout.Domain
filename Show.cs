using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmericanBlackout.Domain.Redis;

namespace AmericanBlackout.Domain
{
    public class Show : RedisItem
    {
        public DateTime Date { get; set; }
        public long VenueId { get; set; }
        public List<long> BandIds { get; set; }
        public string TicketLink { get; set; }
        public string TicketText { get; set; }
        public string PosterLink { get; set; }
        public string PosterLinkSmall
        {
            get
            {
                return string.Format("{0}{1}{2}",
                    PosterLink.Substring(0, PosterLink.IndexOf('.')), "s",
                    PosterLink.Substring(PosterLink.IndexOf('.'), PosterLink.Length - PosterLink.IndexOf('.')));
            }
        }
    }
}
