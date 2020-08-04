using Moryx.AbstractionLayer.Products;
using System.ComponentModel;

namespace MyApplication.Products
{
    public class FoodType : ProductType
    {
        [DisplayName("Size")]
        [Description("Approximate size including any wrapping material")]
        public int Size { get; set; }

        [DisplayName("Diety Restricitons")]
        [Description("The diety restrictions this product complies with")]
        public DietyRestrictions DietyRestrictions {get; set;}

        protected override ProductInstance Instantiate()
        {
            return new FoodInstance();
        }
    }
}
