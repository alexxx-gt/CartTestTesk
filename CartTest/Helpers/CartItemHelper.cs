using CartTestTask.Infrastructure.Constants;
using CartTestTask.Models;

namespace CartTest.Helpers
{
    internal static class CartItemHelper
    {
        internal static CartItem AddShurikens(int quantity)
        {
            CartItem model = new CartItem();

            model.Id = ProductConstants.SHURICKEN_ID;
            model.ProductName = ProductConstants.SHURICKEN_NAME;
            model.Description = ProductConstants.SHURICKEN_DESCRIPTION;
            model.CostPerUnit = ProductConstants.SHURICKEN_COST;
            model.Quantity = quantity;

            return model;
        }

        internal static CartItem AddBagOfPogs(int quantity)
        {
            CartItem model = new CartItem();

            model.Id = ProductConstants.BAG_OF_POGS_ID;
            model.ProductName = ProductConstants.BAG_OF_POGS_NAME;
            model.Description = ProductConstants.BAG_OF_POGS_DESCRIPTION;
            model.CostPerUnit = ProductConstants.BAG_OF_POGS_COST;
            model.Quantity = quantity;

            return model;
        }

        internal static CartItem AddLargeBowl(int quantity)
        {
            CartItem model = new CartItem();

            model.Id = ProductConstants.LARGE_BOWL_ID;
            model.ProductName = ProductConstants.LARGE_BOWL_NAME;
            model.Description = ProductConstants.LARGE_BOWL_DESCRIPTION;
            model.CostPerUnit = ProductConstants.LARGE_BOWL_COST;
            model.Quantity = quantity;

            return model;
        }

        internal static CartItem AddPaperMask(int quantity)
        {
            CartItem model = new CartItem();

            model.Id = ProductConstants.PAPER_MASK_ID;
            model.ProductName = ProductConstants.PAPER_MASK_NAME;
            model.Description = ProductConstants.PAPER_MASK_DESCRIPTION;
            model.CostPerUnit = ProductConstants.PAPER_MASK_COST;
            model.Quantity = quantity;

            return model;
        }
    }
}
