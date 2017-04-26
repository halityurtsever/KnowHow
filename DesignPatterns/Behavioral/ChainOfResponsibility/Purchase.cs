
namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class Purchase
    {
        //################################################################################
        #region Fields

        private readonly int m_Amount;
        private readonly double m_Price;

        #endregion

        //################################################################################
        #region Constructor

        public Purchase(int amount, double price)
        {
            this.m_Amount = amount;
            this.m_Price = price;
        }

        #endregion

        //################################################################################
        #region Properties

        internal int Amount => this.m_Amount;

        internal double Price => this.m_Price;

        #endregion
    }
}
