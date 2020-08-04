using Moryx.Runtime.Container;
using Moryx.Runtime.Modules;
using FoodShareMory.Facade;
using FoodShareMory.Module.Components;
using FoodShareMory.Module.Facade;
using FoodShareMory.Plugins;
using Moryx.AbstractionLayer.Products;
using Moryx.AbstractionLayer.Resources;

namespace FoodShareMory.Module.ModuleController
{
    [ServerModule(ModuleName)]
    //public class ModuleController : ServerModuleBase<ModuleConfig> // No facade export
    public class ModuleController : ServerModuleFacadeControllerBase<ModuleConfig>, IFacadeContainer<IMyFacade> // Facade export
    {
        internal const string ModuleName = "FoodSupplyManagement";

        public override string Name => ModuleName;

        // Import a data model
        //[Named(SomeConstants.Namespace)]
        //public IUnitOfWorkFactory MyModel { get; set; }
        
        [RequiredModuleApi(IsStartDependency = true, IsOptional = false)]
        public IResourceManagement ResourceManagement { get; set; }

        [RequiredModuleApi(IsStartDependency = true, IsOptional = false)]
        public IProductManagement ProductManagement { get; set; }


        #region State transition

        /// <summary>
        /// Code executed on start up and after service was stopped and should be started again
        /// </summary>
        protected override void OnInitialize()
        {
            // Register model
            //Container.SetInstance(MyModel);

            // Register required facade
            //Container.SetInstance(Dependency);
            
            // Load plugins
            Container.LoadComponents<IMyModulesPlugin>();
        }

        /// <summary>
        /// Code executed after OnInitialize
        /// </summary>
        protected override void OnStart()
        {
            // Start component
            Container.Resolve<IFoodSupplyManagement>().Start();

            ActivateFacade(_myFacade);
        }

        /// <summary>
        /// Code executed when service is stopped
        /// </summary>
        protected override void OnStop()
        {
            // Tear down facades
            DeactivateFacade(_myFacade);

            Container.Resolve<IFoodSupplyManagement>().Stop();
        }

        #endregion

        #region FacadeContainer

        private readonly FoodSupplyManagementFacade _myFacade = new FoodSupplyManagementFacade();
        IMyFacade IFacadeContainer<IMyFacade>.Facade => _myFacade;

        #endregion
    }
}