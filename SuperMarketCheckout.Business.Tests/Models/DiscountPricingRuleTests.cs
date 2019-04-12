using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketCheckout.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Tests.Models
{
    [TestClass]
    public class DiscountPricingRuleTests
    {
        #region NewDiscountPricingRule

        [TestMethod]
        public void NewDiscountPricingRule_For0Units_ThrowsArgumentOutOfRangeException()
        {
            var units = 0;
            var discountPrice = 15;
            var regularPricingRule = new RegularPricingRule();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                new DiscountPricingRule(units, discountPrice, regularPricingRule));
        }

        [TestMethod]
        public void NewDiscountPricingRule_For0DiscountPrice_ThrowsArgumentOutOfRangeException()
        {
            var units = 1;
            var discountPrice = 0;
            var regularPricingRule = new RegularPricingRule();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                new DiscountPricingRule(units, discountPrice, regularPricingRule));
        }

        [TestMethod]
        public void NewDiscountPricingRule_ForNullRegularPricingRule_ThrowsArgumentNulLException()
        {
            var units = 1;
            var discountPrice = 10;

            Assert.ThrowsException<ArgumentNullException>(() =>
                new DiscountPricingRule(units, discountPrice, null));
        }

        #endregion
        #region ApplyPrice

        [TestMethod]
        public void ApplyPrice_For()
        {
            // Init
            var units = 3;
            var discountPrice = 25;
            var regularPricingRule = new RegularPricingRule();
            var discountPricingRule = new DiscountPricingRule(units, discountPrice, regularPricingRule);
            var orderItem = new OrderItem
            {
                Product = new Product
                {
                    UnitPrice = 10
                },
                Units = 4
            };

            // Call
            var price = discountPricingRule.ApplyPrice(orderItem);

            // Assert
            Assert.AreEqual(35, price);
        }

        #endregion
    }
}
