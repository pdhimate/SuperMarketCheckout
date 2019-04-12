using SuperMarketCheckout.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperMarketCheckout.Business
{
    public class ProductEngine
    {
        private readonly ICollection<Product> _products;
        private readonly IBillingRegister _billingRegister;

        public ProductEngine(ICollection<Product> products,
            IBillingRegister billingRegister)
        {
            _products = products;
            _billingRegister = billingRegister;
        }

        public decimal Checkout()
        {
            var cartItems = _products.GroupBy(p => p.Id)
                .Select(g =>
                  new OrderItem
                  {
                      Product = g.First(),
                      Units = g.Count()
                  }).ToList();

            return _billingRegister.Checkout(cartItems);
        }
    }
}
