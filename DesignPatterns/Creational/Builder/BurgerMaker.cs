using DesignPatterns.Structural.Creational.Builders;

namespace DesignPatterns.Structural.Creational
{
    internal class BurgerMaker
    {
        //################################################################################
        #region Fields

        private readonly BurgerBuilder m_BurgerBuilder;

        #endregion

        //################################################################################
        #region Constructor

        public BurgerMaker(BurgerBuilder burgerBuilder)
        {
            m_BurgerBuilder = burgerBuilder;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal Burger GetBurger()
        {
            return m_BurgerBuilder.ServeBurger();
        }

        internal void PrepareBurger()
        {
            m_BurgerBuilder.CreateBurger();

            m_BurgerBuilder.PrepareBread();
            m_BurgerBuilder.AddMeatAndCheese();
            m_BurgerBuilder.AddVegetables();
            m_BurgerBuilder.AddCondiments();
        }

        #endregion
    }
}
