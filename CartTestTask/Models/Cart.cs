using System;
using System.Collections.Generic;
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
