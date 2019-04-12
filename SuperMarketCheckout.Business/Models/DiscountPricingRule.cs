using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    public class DiscountPricingRule : IPricingRule
    {
        private int _units;

        /// <summary>
        /// The offer/discounted price for the number of <see cref="_units"/> purchased
        /// </summary>

        private decimal _discountPrice;

        public DiscountPricingRule(int units, decimal discountPrice)
        {
            _units = units;
            _discountPrice = discountPrice;
        }

        public decimal ApplyPrice(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
