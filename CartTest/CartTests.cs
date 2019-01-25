using System;
using System.Collections.Generic;
using System.Text;
using CartTest.Helpers;
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
            Cart cart = CartHelper.CreateCart();
            cart.AddItem();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestRemoveItem()
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
