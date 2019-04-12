using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    class Product
    {
        public int Id { get; set; }

        public decimal UnitPrice { get; set; }

        public IList<IPricingRule> PricingRules { get; set; }
    }

}
