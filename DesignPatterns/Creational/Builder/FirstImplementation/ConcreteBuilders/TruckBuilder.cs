using DesignPatterns.Creational.Builder.FirstImplementation.Product;

namespace DesignPatterns.Creational.Builder.FirstImplementation.ConcreteBuilders
{
    internal class TruckBuilder : VehicleBuilder
    {
        //################################################################################
        #region Constructor

        public TruckBuilder()
        {
            this.m_Vehicle = new Vehicle("Truck");
        }

        #endregion

        //################################################################################
        #region VehicleBuilder Overrides

        internal override void BuildBrand()
        {
            this.Vehicle.Brand = "DAF";
        }

        internal override void BuildEngine()
        {
            this.Vehicle.Engine = "V12";
        }

        internal override void BuildWheels()
        {
            this.Vehicle.Wheels = 18;
        }

        internal override void BuildDoors()
        {
            this.Vehicle.Doors = 2;
        }

        #endregion
    }
}
