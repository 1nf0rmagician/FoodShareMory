using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Device.Location;
using System.Runtime.Serialization;
using Moryx.AbstractionLayer;
using Moryx.AbstractionLayer.Products;
using Moryx.AbstractionLayer.Resources;
using MyApplication.Capabilities;

namespace MyApplication.Resources.MyResource
{
    [ResourceRegistration] // Only necessary for dependency injection like logging or parallel operations
    public class FoodCompartement : PublicResource, IFoodCompartement
    {
        [DataMember, EditorBrowsable]
        [Description("Location of the Food Compartement")]
        public GeoCoordinate Location { get; set; }

        [DataMember, EditorBrowsable]
        [Description("Maximum capacity of the food compartement")]
        public int Capacity { get; set; }

        [DataMember]
        public ICollection<ProductInstance> CurrentFoodSupply { get; set; }

        public event EventHandler FoodSupplyChanged;
    }
}