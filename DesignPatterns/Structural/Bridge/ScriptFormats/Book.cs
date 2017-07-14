using System;

using DesignPatterns.Structural.Bridge.Formatter;

namespace DesignPatterns.Structural.Bridge.ScriptFormats
{
    internal class Book : ScriptBase
    {
        //################################################################################
        #region Constructor

        public Book(IFormatter formatter) : base(formatter)
        {

        }

        #endregion

        //################################################################################
        #region Properties

        internal string Name { get; set; }

        internal string Author { get; set; }

        internal int Pages { get; set; }

        #endregion

        //################################################################################
        #region ScriptBase Implementation

        public override void Print()
        {
            Console.WriteLine(m_Formatter.Format("Name", Name));
            Console.WriteLine(m_Formatter.Format("Author", Author));
            Console.WriteLine(m_Formatter.Format("Page Count", Pages.ToString()));
        }

        #endregion
    }
}
