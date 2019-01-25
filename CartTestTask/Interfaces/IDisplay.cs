using System;
using System.Collections.Generic;
using System.Text;

namespace CartTestTask.Interfaces
{
    public interface IDisplay
    {
        void GetProductList();
        int GetProductCount(string itemId);
        decimal GetItemSubtotal(string itemId);
        decimal GetBasketSubtotal();
        void GetDiscount();
        decimal GetGrandTotal();
    }
}
