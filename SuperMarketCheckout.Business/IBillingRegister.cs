using System.Collections.Generic;
using SuperMarketCheckout.Business.Models;

namespace SuperMarketCheckout.Business
{
    public interface IBillingRegister
    {
        decimal Checkout(ICollection<OrderItem> orderItems);
    }
}