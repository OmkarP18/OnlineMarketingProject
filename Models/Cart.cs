using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlinemarketing.Models
{
    public class Cart
    {

        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public int Quantity { get; set; }
        public Nullable <int> pro_price { get; set; }
        public Nullable <int> Total { get; set; }
        public string pro_image { get; set; }
    }
}