using System;
using System.Collections.Generic;
using System.Text;
using CartTest.Helpers;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CartTest
{
    [TestClass]
    public class DisplayTests
    {
        [TestMethod]
        public void TestGetProductList()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestGetProductCountExistingProduct()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(2, cart.GetProductCount(ProductConstants.BAG_OF_POGS_ID));
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestGetProductCountNotExistingProduct()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(2, cart.GetProductCount(ProductConstants.LARGE_BOWL_ID));
        }

        [TestMethod]
        public void TestGetItemSubtotalExisting()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(10.62M, cart.GetItemSubtotal(ProductConstants.BAG_OF_POGS_ID));
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestGetItemSubtotalNotExisting()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(10.62M, cart.GetItemSubtotal(ProductConstants.LARGE_BOWL_ID));
        }

        [TestMethod]
        public void TestGetBasketSubtotal()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(144.87M, cart.GetBasketSubtotal());
        }

        [TestMethod]
        public void TestGetBasketSubtotalEmptyCart()
        {
            Cart cart = CartHelper.CreateEmptyCart();

            Assert.AreEqual(0M, cart.GetBasketSubtotal());
        }

        [TestMethod]
        public void TestGetDiscount()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestGetGrandTotal()
        {
            Assert.IsTrue(true);
        }
    }
}
