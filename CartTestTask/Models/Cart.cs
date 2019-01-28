using CartTestTask.Infrastructure.Constants;
using CartTestTask.Infrastructure.DiscountChainHandling;
using CartTestTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CartTestTask.Models
{
    public class Cart : ICart, IDisplay
    {
        public List<CartItem> ItemsList { get; set; } = new List<CartItem>();
        public decimal GrandTotal { get; set; }
        public List<CartItem> BonusItemsList { get; set; } = new List<CartItem>();
        public List<string> DiscountsList { get; set; } = new List<string>();

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
            GrandTotal = GlobalConstants.ZERO_DECIMAL;
            DiscountsList = new List<string>();
            BonusItemsList = new List<CartItem>();

            BagsOfPogsDiscountHandler bagsOfPogs = new BagsOfPogsDiscountHandler();
            LargeBowlOfTriffleDiscount bowlOfTriffle = new LargeBowlOfTriffleDiscount();
            ShurikensDiscount shurikens = new ShurikensDiscount();
            bagsOfPogs.Successor = bowlOfTriffle;
            bowlOfTriffle.Successor = shurikens;

            bagsOfPogs.Handle(this);

            //Also, here is a possibility to implement discounts system using extension methods
        }

        public List<CartItem> GetProductList()
        {
            return ItemsList;
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

        public List<string> GetDiscount()
        {
            ApplyDiscountCart();

            return DiscountsList;
        }

        public decimal GetGrandTotal()
        {
            ApplyDiscountCart();

            return GrandTotal;
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
