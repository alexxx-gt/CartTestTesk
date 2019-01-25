using System;
using System.Collections.Generic;
using System.Text;

namespace CartTestTask.Models
{
    public class CartItem
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal CostPerUnit { get; set; }
    }
}
