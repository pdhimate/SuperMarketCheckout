using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    public class RegularPricingRule : IPricingRule
    {
        public decimal ApplyPrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
