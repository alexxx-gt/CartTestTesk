using CartTestTask.Models;
using System.Collections.Generic;

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
