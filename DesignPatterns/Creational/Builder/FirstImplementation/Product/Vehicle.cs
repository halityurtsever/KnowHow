using System;

namespace DesignPatterns.Creational.Builder.FirstImplementation.Product
{
    public class Vehicle
    {
        //################################################################################
        #region Fields

        private readonly string m_Type;

        #endregion

        //################################################################################

        #region Constructor

        public Vehicle(string type)
        {
            m_Type = type;
        }

        #endregion

        //################################################################################

        #region Properties

        internal string Type => this.m_Type;

        internal string Brand { get; set; }

        internal string Engine { get; set; }

        internal int Wheels { get; set; }

        internal int Doors { get; set; }

        #endregion

        //################################################################################

        #region Internal Implementation

        internal void Show()
        {
            Console.WriteLine($"Vehicle Type: {this.Type}");
            Console.WriteLine($"Brand: {this.Brand}");
            Console.WriteLine($"Engine: {this.Engine}");
            Console.WriteLine($"Wheels: {this.Wheels}");
            Console.WriteLine($"Doors: {this.Doors}");
        }

        #endregion
    }
}
