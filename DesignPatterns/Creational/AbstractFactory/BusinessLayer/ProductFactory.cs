using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.BusinessLayer
{
    internal class ProductFactory : IProductFactory
    {
        ICar IProductFactory.CreateCar()
        {
            return new Car();
        }

        IBus IProductFactory.CreateBus()
        {
            return new Bus();
        }

        ITruck IProductFactory.CreateTruck()
        {
            return new Truck();
        }
    }
}
