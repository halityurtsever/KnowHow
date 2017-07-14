using System;
using System.Collections.Generic;

using DesignPatterns.Structural.Creational.Enums;

namespace DesignPatterns.Structural.Creational
{
    public class Burger
    {
        //################################################################################
        #region Properties

        public BreadType Bread { get; set; }

        public MeatType Meat { get; set; }

        public CheeseType Cheese { get; set; }

        public bool IsToasted { get; set; }

        public bool IsKetchup { get; set; }

        public bool IsMustard { get; set; }

        public bool IsMayonnaise { get; set; }

        public bool IsPickle { get; set; }

        public IList<string> Vegetables { get; set; }

        #endregion

        //################################################################################
        #region Public Implementation

        internal void Serve()
        {
            Console.WriteLine("Burger ready to serve...");
            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Toasted: {IsToasted}");
            Console.WriteLine($"Ketchup: {IsKetchup}");
            Console.WriteLine($"Mayonnaise: {IsMayonnaise}");
            Console.WriteLine($"Mustard: {IsMustard}");
            Console.WriteLine($"Pickle: {IsPickle}");
            Console.WriteLine($"Vegetables: {string.Join(", ", Vegetables)}");
        }

        #endregion
    }
}
