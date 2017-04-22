
namespace DesignPatterns.Creational.AbstractFactory.AbstractionLayer
{
    public interface ICountryFormatFactory
    {
        IAddress CreateAddressFormat();

        IPhoneNumber CreatePhoneNumberFormat();

        ILicencePlate CreateLicencePlateFormat();
    }
}
