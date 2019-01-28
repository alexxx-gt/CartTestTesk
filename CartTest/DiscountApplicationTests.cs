using CartTest.Helpers;
using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CartTest
{
    [TestClass]
    public class DiscountApplicationTests
    {
        [TestMethod]
        public void TestBagsDiscount()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.POGS_DISCOUNT);

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

        [TestMethod]
        public void TestShurikenDiscount()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddShurikens(100));

            List<string> expectedDiscountsList = new List<string>();
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

        [TestMethod]
        public void TestBowlDiscount()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddLargeBowl(1));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.BOWL_DISCOUNT);

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

        [TestMethod]
        public void TestBagsBowlDiscounts()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddLargeBowl(1));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.POGS_DISCOUNT);
            expectedDiscountsList.Add(DiscountConstants.BOWL_DISCOUNT);

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

        [TestMethod]
        public void TestBagsShurikensDiscounts()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddBagOfPogs(2));
            list.Add(CartItemHelper.AddShurikens(100));

            List<string> expectedDiscountsList = new List<string>();
            expectedDiscountsList.Add(DiscountConstants.POGS_DISCOUNT);
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

        [TestMethod]
        public void TestBowlShurikensDiscounts()
        {
            List<CartItem> list = new List<CartItem>();

            list.Add(CartItemHelper.AddLargeBowl(1));
            list.Add(CartItemHelper.AddShurikens(100));

            List<string> expectedDiscountsList = new List<string>();
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

        [TestMethod]
        public void TestAllDiscounts()
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
