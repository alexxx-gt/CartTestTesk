using System;
using System.Collections.Generic;
using System.Text;
using CartTestTask.Interfaces;

namespace CartTestTask.Models
{
    public class Cart : ICart, IDisplay
    {
        public List<CartItem> ItemsList { get; set; }
        public decimal GrandTotal { get; set; }
        public List<CartItem> BonusItemsList { get; set; }

        public void AddItem(CartItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(CartItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveSet(CartItem item)
        {
            throw new NotImplementedException();
        }

        public void EmptyCart()
        {
            throw new NotImplementedException();
        }

        public void ApplyDiscount()
        {
            throw new NotImplementedException();
        }

        public void GetProductList()
        {
            throw new NotImplementedException();
        }

        public int GetProductCount()
        {
            throw new NotImplementedException();
        }

        public decimal GetItemSubtotal()
        {
            throw new NotImplementedException();
        }

        public decimal GetBasketSubtotal()
        {
            throw new NotImplementedException();
        }

        public void GetDiscount()
        {
            throw new NotImplementedException();
        }

        public decimal GetGrandTotal()
        {
            throw new NotImplementedException();
        }
    }
}
