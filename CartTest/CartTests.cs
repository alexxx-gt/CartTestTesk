using CartTest.Helpers;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CartTest
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void TestAddItem()
        {
            Cart cart = CartHelper.CreateEmptyCart();

            cart.AddItem(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(1, existingItem?.Quantity);
        }

        [TestMethod]
        public void TestIncreaseItem()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(3));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.AddItem(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(4, existingItem?.Quantity);
        }

        [TestMethod]
        public void TestRemoveItem()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(3));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.RemoveItem(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(2, existingItem?.Quantity);
        }

        [TestMethod]
        public void TestDecreaseItem()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(1));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.RemoveItem(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(null, existingItem?.Quantity);
        }

        [TestMethod]
        public void TestRemoveSet()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(4));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.RemoveSet(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(null, existingItem?.Quantity);
        }

        [TestMethod]
        public void TestEmptyCart()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(4));
            items.Add(CartItemHelper.AddLargeBowl(4));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.EmptyCart();

            Assert.AreEqual(0, cart.ItemsList.Count);
        }

        [TestMethod]
        public void TestApplyDiscount()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(100));
            list.Add(CartItemHelper.AddLargeBowl(1));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.POGS_DISCOUNT);
            expectedDiscountsList.Add(DiscountConstants.BOWL_DISCOUNT);
            expectedDiscountsList.Add(DiscountConstants.SHURIKENS_DISCOUNT);

            Cart cart = CartHelper.CreateNotEmptyCart(list);
            var discountsList = cart.GetDiscount();

            bool equalityCheckResult = expectedDiscountsList.Count == discountsList.Count;

            if (equalityCheckResult)
            {
                for (int i = 0; i < discountsList.Count; i++)
                {
                    if (discountsList[i].Equals(expectedDiscountsList[i]))
                    {
                        continue;
                    }
                    else
                    {
                        equalityCheckResult = false;
                    }
                }
            }

            Assert.IsTrue(equalityCheckResult);
        }
    }
}
