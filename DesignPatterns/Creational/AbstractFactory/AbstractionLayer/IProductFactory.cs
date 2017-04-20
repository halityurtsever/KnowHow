
namespace DesignPatterns.Creational.AbstractFactory.AbstractionLayer
{
    public interface IProductFactory
    {
        ICar CreateCar();

        IBus CreateBus();

        ITruck CreateTruck();
    }
}
