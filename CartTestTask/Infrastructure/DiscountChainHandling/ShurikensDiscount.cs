using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    class ShurikensDiscount : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var shurikensItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.LARGE_BOWL_ID);

            if (shurikensItem != null && shurikensItem.Quantity > DiscountConstants.SHURIKEN_DISCOUNT_QTY)
            {
                cart.DiscountsList.Add(DiscountConstants.SHURIKENS_DISCOUNT);
                cart.GrandTotal += shurikensItem.Quantity * shurikensItem.CostPerUnit;
                cart.GrandTotal = cart.GrandTotal * (1 - DiscountConstants.SHURIKEN_CART_DISCOUNT);

                Successor.Handle(cart);
            }
            else
            {
                Successor.Handle(cart);
            }
        }
    }
}
