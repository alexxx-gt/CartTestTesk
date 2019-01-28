using System;
using System.Collections.Generic;
using System.Text;
using CartTestTask.Models;

namespace CartTestTask.Interfaces
{
    public interface ICart
    {
        List<CartItem> ItemsList { get; set; }
        decimal GrandTotal { get; set; }
        List<CartItem> BonusItemsList { get; set; }
        List<string> DiscountsList { get; set; }

        void AddItem(CartItem item);
        void RemoveItem(CartItem item);
        void RemoveSet(CartItem item);
        void EmptyCart();
        void ApplyDiscountCart();
        ////void ApplyRowDiscount();
    }
}
