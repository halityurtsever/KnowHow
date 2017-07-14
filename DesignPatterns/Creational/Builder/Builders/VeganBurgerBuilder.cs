using System.Collections.Generic;

using DesignPatterns.Structural.Creational.Enums;

namespace DesignPatterns.Structural.Creational.Builders
{
    internal class VeganBurgerBuilder : BurgerBuilder
    {
        //################################################################################
        #region Override Implementation

        public override void PrepareBread()
        {
            m_Burger.Bread = BreadType.Rye;
            m_Burger.IsToasted = false;
        }

        public override void AddMeatAndCheese()
        {
            m_Burger.Meat = MeatType.Soy;
            m_Burger.Cheese = CheeseType.None;
        }

        public override void AddVegetables()
        {
            m_Burger.Vegetables = new List<string>() { "Tomato", "Onion" };
        }

        public override void AddCondiments()
        {
            m_Burger.IsKetchup = true;
            m_Burger.IsMayonnaise = false;
            m_Burger.IsMustard = false;
            m_Burger.IsPickle = true;
        }

        #endregion
    }
}
