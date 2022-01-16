using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaPlWebsite.Models
{
    public class Parcel
    {
        public int Weight { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public string SenderStreet { get; set; }
        public string RecipientStreet { get; set; }
        public string SenderPostalCode { get; set; }
        public string RecipientPostalCode { get; set; }
        public string SenderCity { get; set; }
        public string RecipientCity { get; set; }
        public string SenderCountry { get; set; }
        public string RecipientCountry { get; set; }


    }
}