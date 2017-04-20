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

        private readonly IProductFactory m_Factory;
        private readonly ICar m_CarProduct;
        private readonly IBus m_BusFactory;
        private readonly ITruck m_TruckFactory;

        #endregion

        //################################################################################

        #region Constructor

        public Client()
        {
            this.m_Factory = new
        }

        #endregion

        //################################################################################

        #region Internal Implementation

        #endregion
    }
}
