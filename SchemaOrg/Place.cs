using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain.SchemaOrg
{
    public class Place : Redis.RedisItem, ISchemaOrgItem
    {
        public string SchemaOrgId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Place ContainedIn { get; set; }
        public List<Uri> URLs { get; set; }
        public PostalAddress Address { get; set; }
    }
}
