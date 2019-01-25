using System;
using System.Collections.Generic;
using System.Text;

namespace CartTestTask.Interfaces
{
    public interface IDisplay
    {
        void GetProductList();
        int GetProductCount();
        decimal GetItemSubtotal();
        decimal GetBasketSubtotal();
        void GetDiscount();
        decimal GetGrandTotal();
    }
}
