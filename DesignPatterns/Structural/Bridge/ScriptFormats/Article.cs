using System;

using DesignPatterns.Structural.Bridge.Formatter;

namespace DesignPatterns.Structural.Bridge.ScriptFormats
{
    internal class Article : ScriptBase
    {
        //################################################################################
        #region Constructor

        public Article(IFormatter formatter) : base(formatter)
        {
        }

        #endregion

        //################################################################################
        #region Properties

        internal string Author { get; set; }

        internal string Headline { get; set; }

        internal string Publisher { get; set; }

        #endregion

        //################################################################################
        #region ScriptBase Implementation

        public override void Print()
        {
            Console.WriteLine(m_Formatter.Format("Author", Author));
            Console.WriteLine(m_Formatter.Format("Headline", Headline));
            Console.WriteLine(m_Formatter.Format("Publisher", Publisher));
        }

        #endregion
    }
}
