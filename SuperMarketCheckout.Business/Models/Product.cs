using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    public class Product
    {
        public int Id { get; set; }

        public decimal UnitPrice { get; set; }

        public IList<IPricingRule> PricingRules { get; set; }
    }

}
