using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    interface IPricingRule
    {
        decimal ApplyPrice();
    }
}
