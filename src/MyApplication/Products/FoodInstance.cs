using Moryx.AbstractionLayer.Products;
using System;
using System.ComponentModel;

namespace FoodShareMory.Products
{
    public class FoodInstance : ProductInstance<FoodType>
    {
        [Description("Last date at which this product should be consumed")]
        public DateTime UseByDate { get; set; }
    }
}
