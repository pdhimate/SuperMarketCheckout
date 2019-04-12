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
        [TestMethod]
        public void ApplyPrice_Throws()
        {
            var units = 2;
            var discountPrice = 15;
            var discountPricing = new DiscountPricingRule(units, discountPrice);
            Assert.ThrowsException<NotImplementedException>(() => discountPricing.ApplyPrice(null));
        }
    }
}
