using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CartTestTask.Interfaces;

namespace CartTestTask.Models
{
    public class Cart : ICart, IDisplay
    {
        public List<CartItem> ItemsList { get; set; } = new List<CartItem>();
        public decimal GrandTotal { get; set; }
        public List<CartItem> BonusItemsList { get; set; } = new List<CartItem>();
        public List<string> DiscountsList { get; set; }

        public void AddItem(CartItem item)
        {
            var existingItem = ItemsList.FirstOrDefault(i => i.Id == item.Id);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                ItemsList.Add(item);
            }
        }

        public void RemoveItem(CartItem item)
        {
            var existingItem = ItemsList.FirstOrDefault(i => i.Id == item.Id);

            if (existingItem.Quantity > 1)
            {
                existingItem.Quantity--;
            }
            else
            {
                ItemsList.Remove(existingItem);
            }
        }

        public void RemoveSet(CartItem item)
        {
            ItemsList.Remove(ItemsList.FirstOrDefault(i => i.Id == item.Id));
        }

        public void EmptyCart()
        {
            ItemsList = new List<CartItem>();
        }

        public void ApplyDiscountCart()
        {
            
        }

        public void ApplyRowSubtotalDiscount()
        {
            throw new NotImplementedException();
        }

        public void ApplyRowCountDiscount()
        {
            throw new NotImplementedException();
        }

        public void GetProductList()
        {
            throw new NotImplementedException();
        }

        public int GetProductCount(string itemId)
        {
            var item = ItemsList.FirstOrDefault(i => i.Id == itemId);

            if (item != null)
                return item.Quantity;
            else
                throw new NullReferenceException();
        }

        public decimal GetItemSubtotal(string itemId)
        {
            var item = ItemsList.FirstOrDefault(i => i.Id == itemId);

            if (item != null)
            {
                return item.Quantity * item.CostPerUnit;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public decimal GetBasketSubtotal()
        {
            decimal sum = 0;

            foreach (var item in ItemsList)
            {
                sum += item.Quantity * item.CostPerUnit;
            }

            return sum;
        }

        public void GetDiscount()
        {
            throw new NotImplementedException();
        }

        public decimal GetGrandTotal()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            try
            {
                var comparingObject = (Cart)obj;

                bool comparisonResult = GrandTotal == comparingObject.GrandTotal && 
                                       ItemsList.Count == comparingObject.ItemsList.Count &&
                                       BonusItemsList.Count == comparingObject.BonusItemsList.Count;

                if (comparisonResult)
                {
                    if (ItemsList.Count > 0)
                    {
                        for (int i = 0; i < ItemsList.Count; i++)
                        {
                            if (ItemsList[i].Equals(comparingObject.ItemsList[i]))
                                continue;
                            else
                                comparisonResult = false;
                        }
                    }

                    if (BonusItemsList.Count > 0)
                    {
                        for (int i = 0; i < BonusItemsList.Count; i++)
                        {
                            if (BonusItemsList[i].Equals(comparingObject.BonusItemsList[i]))
                                continue;
                            else
                                comparisonResult = false;
                        }
                    }
                }

                return comparisonResult;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
