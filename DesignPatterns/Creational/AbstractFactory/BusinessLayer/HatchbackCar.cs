using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.BusinessLayer
{
    internal class HatchbackCar : ICar
    {
        string ICar.GetBrand
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        void ICar.FillGas()
        {
            throw new System.NotImplementedException();
        }
    }
}
