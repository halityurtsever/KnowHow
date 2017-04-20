using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.BusinessLayer
{
    internal class Bus : IBus
    {
        int IBus.GetSeatCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        bool IBus.IsSchoolBus()
        {
            throw new System.NotImplementedException();
        }
    }
}
