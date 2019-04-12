using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    public interface IPricingRule
    {
        decimal ApplyPrice(OrderItem orderItem);
    }
}
