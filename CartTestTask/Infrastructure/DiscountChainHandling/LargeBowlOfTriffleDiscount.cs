using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using System.Linq;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    class LargeBowlOfTriffleDiscount : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var largeBowlItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.LARGE_BOWL_ID);

            if (largeBowlItem != null)
            {
                cart.DiscountsList.Add(DiscountConstants.BOWL_DISCOUNT);
                cart.GrandTotal += largeBowlItem.CostPerUnit * largeBowlItem.Quantity;
                cart.BonusItemsList.Add(new CartItem
                {
                    CostPerUnit = 0M,
                    Description = ProductConstants.PAPER_MASK_DESCRIPTION,
                    Id = ProductConstants.PAPER_MASK_ID,
                    ProductName = ProductConstants.PAPER_MASK_NAME,
                    Quantity = 1
                });

                if (Successor != null)
                {
                    Successor.Handle(cart);
                }
            }
            else if (Successor != null)
            {
                //cart.GrandTotal += largeBowlItem.CostPerUnit * largeBowlItem.Quantity;
                Successor.Handle(cart);
            }
        }
    }
}
