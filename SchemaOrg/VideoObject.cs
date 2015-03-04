using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanBlackout.Domain.SchemaOrg
{
    public class VideoObject
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public Uri ThumbnailURL { get; set; }
        public Uri URL { get; set; }
    }
}
