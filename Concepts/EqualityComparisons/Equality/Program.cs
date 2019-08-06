using System;

namespace Equality
{
    class Program
    {
        static void Main()
        {
            //Equality for floating points
            float six = 6.0000000f;
            float nearlySix = 6.0000001f;

            /**
             * Reason: Computers can only store certain levels of digits after floating point.
             * Precision may lose while rounding values.
             */
            Console.WriteLine(six == nearlySix); //return True

            //Another example
            float x = 5.05f;
            float y = 0.95f;

            Console.WriteLine($"Result: {x + y}");
            Console.WriteLine($"x + y == 6 ? => {x + y == 6f}");

            /**
             * Rounding errors happen in the floating pointing arithmetic,
             * and .NET has no solution for this.
             * Problem normally happens on equality operator,
             * but doesn't affect less-than or greater-than comparisons.
             */

            Console.ReadLine();
        }
    }

    class Food : IEquatable<Food>
    {
        public virtual bool Equals(Food other)
        {
            throw new NotImplementedException();
        }
    }

    class CookedFood : Food, IEquatable<CookedFood>
    {
        /**
         * In here, we may override Equals method in Food class.
         * But this would be a mistake, because overriden method will take Food as a parameter that will return wornd results.
         * 
         * The only workaround: Lose type safety
         * This means implementing IEquatable<object> instead of IEquatable<Food>.
         * Thus we may override Equals method in derived class.
         */
        public virtual bool Equals(CookedFood other)
        {
            throw new NotImplementedException();
        }
    }
}
