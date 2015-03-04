using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmericanBlackout.Domain.SchemaOrg
{
    public class MusicGroup : Redis.RedisItem, ISchemaOrgItem
    {
        public string SchemaOrgId { get; set; }
        public string Name { get; set; }
        public List<Uri> URLs { get; set; }
        public long FoundingLocationId {get;set;}
        public string Genre { get; set; }
        public List<long> AlbumIds { get; set; }
        public List<long> MemberIds { get; set; }
        public List<long> EventIds { get; set; }
        public List<Uri> Images { get; set; }
        public List<long> VideoIds { get; set; }
    }
}
