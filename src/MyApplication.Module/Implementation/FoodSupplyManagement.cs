using Moryx.Container;
using FoodShareMory.Module.Components;

namespace FoodShareMory.Module.Implementation
{
    [Component(LifeCycle.Singleton, typeof(IFoodSupplyManagement))]
    public class FoodSupplyManagement : IFoodSupplyManagement
    {
        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}