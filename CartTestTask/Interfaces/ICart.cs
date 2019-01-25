using System;
using System.Collections.Generic;
using System.Text;

namespace CartTestTask.Interfaces
{
    public interface ICart
    {
        void AddItem();
        void RemoveItem();
        void RemoveSet();
        void EmptyCart();
        void ApplyDiscount();
    }
}
