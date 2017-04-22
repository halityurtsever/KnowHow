using DesignPatterns.Creational.Builder.FirstImplementation.ConcreteBuilders;

namespace DesignPatterns.Creational.Builder.FirstImplementation
{
    internal class Client
    {
        private VehicleBuilder m_Builder;

        internal void BuildVehicle()
        {
            //Car
            this.m_Builder = new CarBuilder();
            this.ConstructVehicle();

            //Truck
            this.m_Builder = new TruckBuilder();
            this.ConstructVehicle();

            //Bicycle
            this.m_Builder = new BicycleBuilder();
            this.ConstructVehicle();
        }

        private void ConstructVehicle()
        {
            VehicleConstructor.Construct(this.m_Builder);
            this.m_Builder.Vehicle.Show();
        }
    }
}
