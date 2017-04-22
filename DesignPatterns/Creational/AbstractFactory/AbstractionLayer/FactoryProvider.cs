using System;
using DesignPatterns.Creational.AbstractFactory.BusinessLayer;

namespace DesignPatterns.Creational.AbstractFactory.AbstractionLayer
{
    public static class FactoryProvider
    {
        public static ICountryFormatFactory CreateFactory(CountryCode countryCode)
        {
            switch (countryCode)
            {
                case CountryCode.TR:
                    return new TurkeyFormat();

                case CountryCode.D:
                    return new GermanyFormat();

                default:
                    throw new ArgumentException();
            }
        }
    }
}
