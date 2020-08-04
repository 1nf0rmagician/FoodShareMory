using Moryx.Container;
using FoodShareMory.Module.Components;

namespace FoodShareMory.Module.Implementation
{
    [Component(LifeCycle.Singleton, typeof(IMyComponent))]
    public class Component : IMyComponent
    {
        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}