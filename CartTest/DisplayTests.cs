using CartTest.Helpers;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CartTest
{
    [TestClass]
    public class DisplayTests
    {
        [TestMethod]
        public void TestGetProductList()
        {
            List<CartItem> list = new List<CartItem>();
            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(15));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            bool equalityCheckResult = true;
            for (int i = 0; i < cart.ItemsList.Count; i++)
            {
                if (cart.ItemsList[i].Equals(list[i]))
                {
                    continue;
                }
                else
                {
                    equalityCheckResult = false;
                }
            }

            Assert.IsTrue(equalityCheckResult);
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
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(100));
            list.Add(CartItemHelper.AddLargeBowl(1));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.POGS_DISCOUNT);
            expectedDiscountsList.Add(DiscountConstants.BOWL_DISCOUNT);
            expectedDiscountsList.Add(DiscountConstants.SHURIKENS_DISCOUNT);

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            var discountList = cart.GetDiscount();

            bool equalityCheckResult = discountList.Count == expectedDiscountsList.Count;

            if (equalityCheckResult)
            {
                for (int i = 0; i < discountList.Count; i++)
                {
                    if (cart.DiscountsList[i].Equals(expectedDiscountsList[i]))
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

        [TestMethod]
        public void TestGetGrandTotal()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(100));
            list.Add(CartItemHelper.AddLargeBowl(1));

            Cart cart = CartHelper.CreateNotEmptyCart(list);

            Assert.AreEqual(634.0005M, cart.GetGrandTotal());
        }

        [TestMethod]
        public void TestGetGrandTotalEmptyCart()
        {
            Cart cart = CartHelper.CreateEmptyCart();

            Assert.AreEqual(0, cart.GetGrandTotal());
        }
    }
}
