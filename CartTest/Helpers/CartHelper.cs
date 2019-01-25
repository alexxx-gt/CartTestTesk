using System;
using System.Collections.Generic;
using System.Text;
using CartTestTask.Models;

namespace CartTest.Helpers
{
    internal static class CartHelper
    {
        internal static Cart CreateEmptyCart()
        {
            return new Cart();
        }

        internal static Cart CreateNotEmptyCart(List<CartItem> itemsList)
        {
            Cart cart = new Cart();

            cart.ItemsList = itemsList;

            return cart;
        }
    }
}
