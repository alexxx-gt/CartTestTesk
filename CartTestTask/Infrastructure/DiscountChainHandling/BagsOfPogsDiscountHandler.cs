using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using System.Linq;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    public class BagsOfPogsDiscountHandler : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var bagOfPogsItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.BAG_OF_POGS_ID);

            if (bagOfPogsItem != null && bagOfPogsItem.Quantity >= DiscountConstants.POGS_DISCOUNT_QTY)
            {
                if (!cart.DiscountsList.Contains(DiscountConstants.POGS_DISCOUNT))
                {
                    cart.DiscountsList.Add(DiscountConstants.POGS_DISCOUNT);
                    cart.GrandTotal += bagOfPogsItem.CostPerUnit +
                                       (bagOfPogsItem.Quantity - 1) * bagOfPogsItem.CostPerUnit * (1 - DiscountConstants.POGS_EXTRA_ITEM_DISCOUNT);
                }

                if (Successor != null)
                {
                    Successor.Handle(cart);
                }
            }
            else if (Successor != null)
            {
                if (bagOfPogsItem != null)
                {
                    cart.GrandTotal += bagOfPogsItem.CostPerUnit * bagOfPogsItem.Quantity;
                }
                
                Successor.Handle(cart);
            }
        }
    }
}
