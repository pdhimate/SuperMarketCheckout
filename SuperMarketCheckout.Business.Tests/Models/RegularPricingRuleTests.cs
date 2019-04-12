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
        public void ApplyPrice_Throws()
        {
            var regularPricing = new RegularPricingRule();
            Assert.ThrowsException<NotImplementedException>(() => regularPricing.ApplyPrice(null));
        }

        #endregion
    }
}
