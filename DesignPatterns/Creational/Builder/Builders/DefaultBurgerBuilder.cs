using System.Collections.Generic;

using DesignPatterns.Structural.Creational.Enums;

namespace DesignPatterns.Structural.Creational.Builders
{
    internal class DefaultBurgerBuilder : BurgerBuilder
    {
        //################################################################################
        #region Override Implementation

        public override void PrepareBread()
        {
            m_Burger.Bread = BreadType.Wheat;
            m_Burger.IsToasted = true;
        }

        public override void AddMeatAndCheese()
        {
            m_Burger.Meat = MeatType.Salami;
            m_Burger.Cheese = CheeseType.Ezine;
        }

        public override void AddVegetables()
        {
            m_Burger.Vegetables = new List<string>() { "Tomato", "Lettuce" };
        }

        public override void AddCondiments()
        {
            m_Burger.IsKetchup = true;
            m_Burger.IsMayonnaise = true;
            m_Burger.IsMustard = true;
            m_Burger.IsPickle = false;
        }

        #endregion
    }
}
