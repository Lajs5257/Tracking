using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tracking.Entities
{
    public class Request
    {
        public string token { get; set; }
        public DateTime fh_start { get; set; }
        public DateTime fh_end { get; set; }
        public string shipment { get; set; }
        
    }
}
