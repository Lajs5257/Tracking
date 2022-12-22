using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tracking.Entities
{
    public class TrackingInfo
    {
        public long? supply_chain_id { get; set; }
        public long? id { get; set; }
        public string? plante { get; set; }
        public string? shipment { get; set; }
        public string? transline_name { get; set; }
        public int? transline_id { get; set; }
        public int? legacy_code { get; set; }
        public string? timezone { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public int? speed { get; set; }
        public int? distance_to_route { get; set; }
        public int? distance_to_end_route { get; set; }
        public string? odometer { get; set; }
        public string? code { get; set; }
        public string? altitude { get; set; }
        public int? ignition { get; set; }
        public int? batery { get; set; }
        public string? course { get; set; }
    }
}
