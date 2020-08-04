using Moryx.AbstractionLayer.Capabilities;

namespace MyApplication.Capabilities
{
    /// <summary>
    /// Class that represents the cooling capabilities
    /// </summary>
    public class CoolingCapabilities : ConcreteCapabilities
    {
        /// <summary>
        /// Required: Required  degree of cooling
        /// Provided: Provided degree of cooling
        /// </summary>
        public CoolingType CoolingType { get; set; }

        protected override bool ProvidedBy(ICapabilities provided)
        {
            var providedSome = provided as CoolingCapabilities;
            if (providedSome == null)
                return false;

            if (providedSome.CoolingType == CoolingType) // Provided must be greater or equal
                return false;

            return true;
        }
    }
}