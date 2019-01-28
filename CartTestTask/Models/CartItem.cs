using System;

namespace CartTestTask.Models
{
    public class CartItem
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal CostPerUnit { get; set; }

        public override bool Equals(object obj)
        {
            try
            {
                var comparingObject = (CartItem)obj;

                return Id == comparingObject.Id && ProductName.Equals(comparingObject.ProductName) &&
                    Description.Equals(comparingObject.Description) && Quantity == comparingObject.Quantity &&
                    CostPerUnit == comparingObject.CostPerUnit;
            }
            catch (InvalidCastException e)
            {
                throw e;
            }
        }
    }
}
