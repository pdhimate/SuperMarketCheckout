using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Models
{
    public class DiscountPricingRule : IPricingRule
    {
        private readonly int _threshholdUnits;

        /// <summary>
        /// The offer/discounted price for the number of <see cref="_threshholdUnits"/> purchased
        /// </summary>

        private readonly decimal _discountPrice;

        private readonly IPricingRule _regularPricingRule;

        public DiscountPricingRule(int threshholdUnits, decimal discountPrice,
            IPricingRule regularPricingRule)
        {
            //Validations
            if (threshholdUnits < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(threshholdUnits));
            }
            if (discountPrice < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(discountPrice));
            }
            if (regularPricingRule == null)
            {
                throw new ArgumentNullException(nameof(regularPricingRule));
            }

            // Init fields
            _threshholdUnits = threshholdUnits;
            _discountPrice = discountPrice;
            _regularPricingRule = regularPricingRule;
        }

        public decimal ApplyPrice(OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem));
            }

            if (orderItem.Units >= _threshholdUnits)
            {
                // Calculate price for discounted items
                var discountedUnitsGroup = orderItem.Units / _threshholdUnits;
                var discountedTotal = discountedUnitsGroup * _discountPrice;

                // Calculate price for remaining items, if any
                var discountedUnits = discountedUnitsGroup * _threshholdUnits;
                var remainingUnits = orderItem.Units - discountedUnits;
                var regularTotal = remainingUnits * orderItem.Product.UnitPrice;

                return discountedTotal + regularTotal;
            }

            return _regularPricingRule.ApplyPrice(orderItem);
        }
    }
}
