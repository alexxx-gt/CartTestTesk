using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using System.Linq;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    class ShurikensDiscount : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var shurikensItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.SHURICKEN_ID);

            if (shurikensItem != null && shurikensItem.Quantity >= DiscountConstants.SHURIKEN_DISCOUNT_QTY)
            {
                cart.DiscountsList.Add(DiscountConstants.SHURIKENS_DISCOUNT);
                cart.GrandTotal += shurikensItem.Quantity * shurikensItem.CostPerUnit;
                cart.GrandTotal = cart.GrandTotal * (1 - DiscountConstants.SHURIKEN_CART_DISCOUNT);

                if (Successor != null)
                {
                    Successor.Handle(cart);
                }
            }
            else if (Successor != null)
            {
                cart.GrandTotal += shurikensItem.Quantity * shurikensItem.CostPerUnit;
                Successor.Handle(cart);
            }
        }
    }
}
