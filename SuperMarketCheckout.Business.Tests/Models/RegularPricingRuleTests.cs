using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketCheckout.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Tests.Models
{
    [TestClass]
    public class RegularPricingRuleTests
    {
        #region ApplyPrice

        [TestMethod]
        public void ApplyPrice_ForNullOrderItem_Throws()
        {
            var regularPricing = new RegularPricingRule();
            Assert.ThrowsException<ArgumentNullException>(() => regularPricing.ApplyPrice(null));
        }

        [TestMethod]
        public void ApplyPrice_Calculates_Price()
        {
            var regularPricing = new RegularPricingRule();
            var orderItem = new OrderItem
            {
                Product = new Product
                {
                    UnitPrice = 10
                },
                Units = 2
            };
            var price = regularPricing.ApplyPrice(orderItem);
            Assert.AreEqual(20, price);
        }

        #endregion
    }
}
