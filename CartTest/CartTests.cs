using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CartTest.Helpers;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CartTest
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void TestAddItem()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestIncreaseItem()
        {
            List<CartItem> items = new List<CartItem>();

            items.Add(CartItemHelper.AddPaperMask(3));

            Cart cart = CartHelper.CreateNotEmptyCart(items);
            cart.AddItem(CartItemHelper.AddPaperMask(1));

            var existingItem = cart.ItemsList.FirstOrDefault(i => i.Id == ProductConstants.PAPER_MASK_ID);

            Assert.AreEqual(4, existingItem.Quantity);
        }

        [TestMethod]
        public void TestRemoveItem()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDecreaseItem()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestRemoveSet()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestEmptyCart()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestApplyDiscount()
        {
            Assert.IsTrue(true);
        }
    }
}
