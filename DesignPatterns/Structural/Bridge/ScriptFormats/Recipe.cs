using System;
using System.Collections.Generic;

using DesignPatterns.Structural.Bridge.Formatter;

namespace DesignPatterns.Structural.Bridge.ScriptFormats
{
    internal class Recipe : ScriptBase
    {
        // ################################################################################
        #region Constructor

        public Recipe(IFormatter formatter) : base(formatter)
        {
        }

        #endregion

        // ################################################################################
        #region Properties

        internal string Name { get; set; }

        internal MealType Type { get; set; }

        internal IList<string> Ingridents { get; set; }

        #endregion

        // ################################################################################
        #region ScriptBase Implementation

        public override void Print()
        {
            Console.WriteLine(m_Formatter.Format("Name", Name));
            Console.WriteLine(m_Formatter.Format("Meal Type", Type.ToString()));
            Console.WriteLine(m_Formatter.Format("Ingridents", string.Join(", ", Ingridents)));
        }

        #endregion
    }

    public enum MealType
    {
        Appetizer,
        MainCourse,
        Dessert
    }
}