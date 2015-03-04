using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain.SchemaOrg
{
    public class PostalAddress
    {
        public string StreetAddress { get; set; }
        public string AddressLocality { get; set; } //city
        public string AddressRegion { get; set; } //state
        public string PostalCode { get; set; }
        public string AddressCountry { get; set; }
    }
}
