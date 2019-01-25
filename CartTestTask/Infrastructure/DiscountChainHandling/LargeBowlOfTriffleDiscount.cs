using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    class LargeBowlOfTriffleDiscount : DiscountHandlerAbstract
    {
        public override void Handle(Cart cart)
        {
            var largeBowlItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.LARGE_BOWL_ID);

            if (largeBowlItem != null)
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
