using System;
using System.Collections.Generic;
using System.Text;
using CartTest.Helpers;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CartTest
{
    [TestClass]
    public class EqualityTests
    {
        [TestMethod]
        public void TestEqualCarts()
        {
            List<CartItem> itemsListOriginal = new List<CartItem>();

            itemsListOriginal.Add(CartItemHelper.AddShurikens(2));
            itemsListOriginal.Add(CartItemHelper.AddLargeBowl(7));
            itemsListOriginal.Add(CartItemHelper.AddPaperMask(3));
            itemsListOriginal.Add(CartItemHelper.AddBagOfPogs(4));

            List<CartItem> itemsListForComparison = new List<CartItem>();

            itemsListForComparison.Add(CartItemHelper.AddShurikens(2));
            itemsListForComparison.Add(CartItemHelper.AddLargeBowl(7));
            itemsListForComparison.Add(CartItemHelper.AddPaperMask(3));
            itemsListForComparison.Add(CartItemHelper.AddBagOfPogs(4));

            Cart cartOriginal = CartHelper.CreateNotEmptyCart(itemsListOriginal);
            Cart cartForComparison = CartHelper.CreateNotEmptyCart(itemsListForComparison);

            Assert.IsTrue(cartOriginal.Equals(cartForComparison));
        }

        [TestMethod]
        public void TestNotEqualCarts()
        {
            List<CartItem> itemsListOriginal = new List<CartItem>();

            itemsListOriginal.Add(CartItemHelper.AddShurikens(2));
            itemsListOriginal.Add(CartItemHelper.AddLargeBowl(7));
            itemsListOriginal.Add(CartItemHelper.AddPaperMask(3));
            itemsListOriginal.Add(CartItemHelper.AddBagOfPogs(4));

            List<CartItem> itemsListForComparison = new List<CartItem>();

            itemsListForComparison.Add(CartItemHelper.AddShurikens(2));
            itemsListForComparison.Add(CartItemHelper.AddPaperMask(1));
            itemsListForComparison.Add(CartItemHelper.AddBagOfPogs(6));

            Cart cartOriginal = CartHelper.CreateNotEmptyCart(itemsListOriginal);
            Cart cartForComparison = CartHelper.CreateNotEmptyCart(itemsListForComparison);

            Assert.IsFalse(cartOriginal.Equals(cartForComparison));
        }

        [TestMethod]
        public void TestEqualCartItems()
        {
            CartItem originalItem = CartItemHelper.AddPaperMask(1);
            CartItem itemForComparison = CartItemHelper.AddPaperMask(1);

            Assert.IsTrue(originalItem.Equals(itemForComparison));
        }

        [TestMethod]
        public void TestNotEqualCartItems()
        {
            CartItem originalItem = CartItemHelper.AddPaperMask(1);
            CartItem itemForComparison = CartItemHelper.AddBagOfPogs(2);

            Assert.IsFalse(originalItem.Equals(itemForComparison));
        }
    }
}
