using System;
using DesignPatterns.Creational.Factory.BusinessLayer;

namespace DesignPatterns.Creational.Factory.AbstractionLayer
{
    public class ProductFactory
    {
        internal IProduct CreateProduct(ProductType type)
        {
            switch (type)
            {
                case ProductType.Bus:
                    return new Bus();

                case ProductType.Car:
                    return new Car();

                case ProductType.Truck:
                    return new Truck();

                default:
                    throw new ArgumentException();
            }
        }
    }
}