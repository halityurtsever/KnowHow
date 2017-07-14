
using DesignPatterns.Structural.Creational.Builders;

namespace DesignPatterns.Structural.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerMaker burgerMaker = new BurgerMaker(new DefaultBurgerBuilder());
            burgerMaker.PrepareBurger();
            Burger burger = burgerMaker.GetBurger();
            burger.Serve();

            burgerMaker = new BurgerMaker(new VeganBurgerBuilder());
            burgerMaker.PrepareBurger();
            Burger veganBurger = burgerMaker.GetBurger();
            veganBurger.Serve();
        }
    }
}
