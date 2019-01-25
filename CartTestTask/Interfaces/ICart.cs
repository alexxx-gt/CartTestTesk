using System;
using System.Collections.Generic;
using System.Text;
using CartTestTask.Models;

namespace CartTestTask.Interfaces
{
    public interface ICart
    {
        void AddItem(CartItem item);
        void RemoveItem(CartItem item);
        void RemoveSet(CartItem item);
        void EmptyCart();
        void ApplyDiscount();
    }
}
