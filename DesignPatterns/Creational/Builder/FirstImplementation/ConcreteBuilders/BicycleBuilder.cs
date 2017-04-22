using DesignPatterns.Creational.Builder.FirstImplementation.Product;

namespace DesignPatterns.Creational.Builder.FirstImplementation.ConcreteBuilders
{
    internal class BicycleBuilder : VehicleBuilder
    {
        //################################################################################
        #region Constructor

        public BicycleBuilder()
        {
            this.m_Vehicle = new Vehicle("Bicycle");
        }

        #endregion

        //################################################################################
        #region VehicleBuilder Overrides

        internal override void BuildBrand()
        {
            this.Vehicle.Brand = "Bianchi";
        }

        internal override void BuildEngine()
        {
            this.Vehicle.Engine = "Human Power";
        }

        internal override void BuildWheels()
        {
            this.Vehicle.Wheels = 2;
        }

        internal override void BuildDoors()
        {
            this.Vehicle.Doors = 0;
        }

        #endregion
    }
}
