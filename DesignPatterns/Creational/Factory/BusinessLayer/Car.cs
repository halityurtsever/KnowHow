using System;
using DesignPatterns.Creational.Factory.AbstractionLayer;

namespace DesignPatterns.Creational.Factory.BusinessLayer
{
    internal class Car : IProduct
    {
        void IProduct.Start()
        {
            throw new NotImplementedException();
        }

        void IProduct.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
