using DesignPatterns.Creational.Factory.AbstractionLayer;

namespace DesignPatterns.Creational.Factory.ApplicationLayer
{
    /**
     * Client only knows abstraction layer. All business layer components are invisible to client.
     */
    internal class Client
    {
        //################################################################################
        #region Fields

        private readonly ProductFactory m_Factory;
        private IProduct m_Product;

        #endregion

        //################################################################################
        #region Constructor

        public Client()
        {
            m_Factory = new ProductFactory();
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal IProduct CreateBus()
        {
            m_Product = m_Factory.CreateProduct(ProductType.Bus);
            return m_Product;
        }

        internal IProduct CreateCar()
        {
            m_Product = m_Factory.CreateProduct(ProductType.Car);
            return m_Product;
        }

        internal IProduct CreateTruck()
        {
            m_Product = m_Factory.CreateProduct(ProductType.Truck);
            return m_Product;
        }

        #endregion
    }
}
