﻿using System;
using Moryx.Runtime.Modules;
using FoodShareMory.Facade;
using FoodShareMory.Module.Components;

namespace FoodShareMory.Module.Facade
{
    public class FoodSupplyManagementFacade : IFacadeControl, IMyFacade
    {
        public IFoodSupplyManagement Component { get; set; }

        public void Activate()
        {
        }

        public void Deactivate()
        {
        }

        public Action ValidateHealthState { get; set; }
    }
}