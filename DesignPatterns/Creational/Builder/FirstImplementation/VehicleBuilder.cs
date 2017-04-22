using DesignPatterns.Creational.Builder.FirstImplementation.Product;

namespace DesignPatterns.Creational.Builder.FirstImplementation
{
    public abstract class VehicleBuilder
    {
        //################################################################################
        #region Fields

        protected Vehicle m_Vehicle;

        #endregion

        //################################################################################
        #region Properties

        internal Vehicle Vehicle => this.m_Vehicle;

        #endregion

        //################################################################################
        #region Abstract Implementation

        internal abstract void BuildBrand();

        internal abstract void BuildEngine();

        internal abstract void BuildWheels();

        internal abstract void BuildDoors();

        #endregion
    }
}
