using System;
using System.Collections.Generic;
using System.Text;

namespace CartTestTask.Interfaces
{
    public interface IDisplay
    {
        void GetProductList();
        void GetProductCount();
        void GetItemSubtotal();
        void GetBasketSubtotal();
        void GetDiscount();
        void GetGrandTotal();
    }
}
