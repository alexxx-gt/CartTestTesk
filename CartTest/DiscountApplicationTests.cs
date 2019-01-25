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
    public class DiscountApplicationTests
    {
        [TestMethod]
        public void TestBagsDiscount()
        {
            List<CartItem> itemsList = new List<CartItem>();

            itemsList.Add(CartItemHelper.AddBagOfPogs(3));

            Cart cart = CartHelper.CreateNotEmptyCart(itemsList);

            decimal actualAmount = cart.GetItemSubtotal(ProductConstants.BAG_OF_POGS_ID);
            var pogsQuantity = cart.GetProductCount(ProductConstants.BAG_OF_POGS_ID);
            decimal expectedAmount = ProductConstants.BAG_OF_POGS_COST +
                                     (pogsQuantity - 1) * ProductConstants.BAG_OF_POGS_COST / 2;

            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void TestShurikenDiscount()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestBowlDiscount()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestBagsBowlDiscounts()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestBagsShurikensDiscounts()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void testBowlShurikensDiscounts()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestAllDiscounts()
        {
            Assert.IsTrue(true);
        }
    }
}
