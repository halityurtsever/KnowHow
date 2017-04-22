using System;
using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.BusinessLayer
{
    internal class GermanyFormat : ICountryFormatFactory
    {
        IAddress ICountryFormatFactory.CreateAddressFormat()
        {
            throw new NotImplementedException();
        }

        IPhoneNumber ICountryFormatFactory.CreatePhoneNumberFormat()
        {
            throw new NotImplementedException();
        }

        ILicencePlate ICountryFormatFactory.CreateLicencePlateFormat()
        {
            throw new NotImplementedException();
        }
    }
}
