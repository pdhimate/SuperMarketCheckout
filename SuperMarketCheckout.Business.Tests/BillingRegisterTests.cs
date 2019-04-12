using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketCheckout.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketCheckout.Business.Tests
{
    [TestClass]
    public class BillingRegisterTests
    {
        [TestMethod]
        public void Checkout()
        {
            var product1 = new Product
            {
                UnitPrice = 10,
                PricingRules = new List<IPricingRule>
                {
                    new RegularPricingRule()
                }
            };
            var regPricingRule = new RegularPricingRule();
            var product2 = new Product
            {
                UnitPrice = 20,
                PricingRules = new List<IPricingRule>
                {
                    regPricingRule,
                    new DiscountPricingRule(2, 35, regPricingRule)
                }
            };

            var cartItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Product = product1,
                    Units = 2
                },
                new OrderItem
                {
                    Product = product2,
                    Units= 3
                }
            };


            var register = new BillingRegister();
            var total = register.Checkout(cartItems);

            Assert.AreEqual(75, total);
        }
    }
}
