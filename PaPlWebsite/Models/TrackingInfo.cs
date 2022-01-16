using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaPlWebsite.Models
{
    public class VisitedHop
    {
        public string code { get; set; }
        public string description { get; set; }
        public DateTime dateTime { get; set; }
    }

    public class FutureHop
    {
        public string code { get; set; }
        public string description { get; set; }
    }
    public class TrackingInfo
    {
        public string TrackingId { get; set; }
        public string Status { get; set; }
        public List<VisitedHop> VisitedHops { get; set; }
        public List<FutureHop> FutureHops { get; set; }
    }
}