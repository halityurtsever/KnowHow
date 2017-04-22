using DesignPatterns.Creational.Builder.FirstImplementation.Product;

namespace DesignPatterns.Creational.Builder.FirstImplementation.ConcreteBuilders
{
    internal class CarBuilder : VehicleBuilder
    {
        //################################################################################
        #region Constructor

        public CarBuilder()
        {
            this.m_Vehicle = new Vehicle("Car");
        }

        #endregion

        //################################################################################
        #region VehicleBuilder Overrides

        internal override void BuildBrand()
        {
            this.Vehicle.Brand = "Audi";
        }

        internal override void BuildEngine()
        {
            this.Vehicle.Engine = "V8";
        }

        internal override void BuildWheels()
        {
            this.Vehicle.Wheels = 4;
        }

        internal override void BuildDoors()
        {
            this.Vehicle.Doors = 4;
        }

        #endregion
    }
}
