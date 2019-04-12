using SuperMarketCheckout.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business
{
    public class BillingRegister
    {
        public decimal Checkout(ICollection<OrderItem> orderItems)
        {
            decimal cartTotal = 0;
            foreach (var orderItem in orderItems)
            {
                var lowestPrice = decimal.MaxValue;
                foreach (var rule in orderItem.Product.PricingRules)
                {
                    var price = rule.ApplyPrice(orderItem);
                    if (price < lowestPrice)
                    {
                        lowestPrice = price;
                    }
                }

                orderItem.Total = lowestPrice;
                cartTotal += lowestPrice;
            }

            return cartTotal;
        }
    }
}
