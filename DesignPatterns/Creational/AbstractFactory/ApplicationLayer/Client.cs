using DesignPatterns.Creational.AbstractFactory.AbstractionLayer;

namespace DesignPatterns.Creational.AbstractFactory.ApplicationLayer
{
    /**
     * Client only knows abstraction layer.
     */
    internal class Client
    {
        //################################################################################
        #region Fields

        private readonly ICountryFormatFactory m_Factory;
        private readonly IAddress m_Address;
        private readonly IPhoneNumber m_PhoneNumber;
        private readonly ILicencePlate m_LicencePlate;

        #endregion

        //################################################################################

        #region Constructor

        public Client(CountryCode countryCode)
        {
            this.m_Factory = FactoryProvider.CreateFactory(countryCode);

            this.m_Address = this.m_Factory.CreateAddressFormat();
            this.m_PhoneNumber = this.m_Factory.CreatePhoneNumberFormat();
            this.m_LicencePlate = this.m_Factory.CreateLicencePlateFormat();
        }

        #endregion

        //################################################################################

        #region Properties

        internal IAddress Address => this.m_Address;

        internal IPhoneNumber PhoneNumber => this.m_PhoneNumber;

        internal ILicencePlate LicencePlate => this.m_LicencePlate;

        #endregion

        //################################################################################

        #region Internal Implementation

        // do something with factory and products

        #endregion
    }
}
