using System;

namespace DesignPatterns.Structural.Composite
{
    internal class Employee : ICompanyUnit
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private int m_Bonus;

        #endregion

        //################################################################################
        #region Constructor

        public Employee(string name)
        {
            m_Name = name;
        }

        #endregion

        //################################################################################
        #region ICompanyUnit Implementation

        int ICompanyUnit.Bonus
        {
            get
            {
                return m_Bonus;
            }
            set
            {
                m_Bonus = value;
            }
        }

        void ICompanyUnit.Stats()
        {
            Console.WriteLine($"{m_Name} is paid {m_Bonus} as bonus.");
        }

        #endregion
    }
}
