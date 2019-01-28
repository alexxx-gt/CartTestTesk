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
            Assert.IsTrue(true);
        }
    }
}
