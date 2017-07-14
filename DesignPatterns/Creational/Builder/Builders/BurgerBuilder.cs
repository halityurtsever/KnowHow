
namespace DesignPatterns.Structural.Creational.Builders
{
    public abstract class BurgerBuilder
    {
        //################################################################################
        #region Fields

        protected Burger m_Burger;

        #endregion

        //################################################################################
        #region Public Implementation

        public void CreateBurger()
        {
            m_Burger = new Burger();
        }

        public Burger ServeBurger()
        {
            return m_Burger;
        }

        #endregion

        //################################################################################
        #region Abstract Members

        public abstract void PrepareBread();

        public abstract void AddMeatAndCheese();

        public abstract void AddVegetables();

        public abstract void AddCondiments();

        #endregion
    }
}
