using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    public class BagsOfPogsDiscountHandler : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var bagOfPogsItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.BAG_OF_POGS_ID);

            if (bagOfPogsItem != null && bagOfPogsItem.Quantity >= 2)
            {
                //Calculations
                Successor.Handle(cart);
            }
            else
            {
                Successor.Handle(cart);
            }
        }
    }
}
