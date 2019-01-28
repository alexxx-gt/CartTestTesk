using CartTestTask.Models;
using System.Collections.Generic;

namespace CartTestTask.Interfaces
{
    public interface IDisplay
    {
        List<CartItem> GetProductList();
        int GetProductCount(string itemId);
        decimal GetItemSubtotal(string itemId);
        decimal GetBasketSubtotal();
        List<string> GetDiscount();
        decimal GetGrandTotal();
    }
}
