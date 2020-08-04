using Moryx.AbstractionLayer.Products;
using Moryx.AbstractionLayer.Resources;
using System;
using System.Collections.Generic;
using System.Device.Location;

namespace MyApplication.Resources
{
    public interface IFoodCompartement : IPublicResource
    {
        /// <summary>
        /// Location of this food compartement
        /// </summary>
        GeoCoordinate Location { get; }

        /// <summary>
        /// Total capacity of this food compartement in liter
        /// </summary>
        int Capacity { get; }

        /// <summary>
        /// Current food supply in the compartement
        /// </summary>
        ICollection<ProductInstance> CurrentFoodSupply { get; set; }

        /// <summary>
        /// Event raise, when availability of items in the compartement changed
        /// </summary>
        event EventHandler FoodSupplyChanged;
    }
}