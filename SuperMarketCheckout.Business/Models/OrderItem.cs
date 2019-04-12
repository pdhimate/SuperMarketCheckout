using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    class OrderItem
    {
        public Product Product { get; set; }

        public int Units { get; set; }

        public decimal Total { get; set; }
    }
}
