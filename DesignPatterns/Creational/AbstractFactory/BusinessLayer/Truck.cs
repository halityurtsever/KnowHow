using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.BusinessLayer
{
    internal class Truck : ITruck
    {
        bool ITruck.Is18Wheels()
        {
            throw new System.NotImplementedException();
        }

        bool ITruck.IsDumperAttached()
        {
            throw new System.NotImplementedException();
        }
    }
}
