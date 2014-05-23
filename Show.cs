using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain
{
    public class Show
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long VenueId { get; set; }
        public List<long> BandIds { get; set; }
        public string TicketLink { get; set; }
        public string PosterLink { get; set; }
    }
}
