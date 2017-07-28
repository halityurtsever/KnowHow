using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    internal class Department : ICompanyUnit
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private readonly IList<ICompanyUnit> m_Employees;

        #endregion

        //################################################################################
        #region Constructor

        public Department(string name)
        {
            m_Name = name;
            m_Employees = new List<ICompanyUnit>();
        }

        #endregion

        //################################################################################
        #region Properties

        public IList<ICompanyUnit> Employees => m_Employees;

        #endregion

        //################################################################################
        #region ICompanyUnit Implementation

        int ICompanyUnit.Bonus
        {
            get
            {
                int totalBonus = 0;
                foreach (ICompanyUnit employee in Employees)
                {
                    totalBonus += employee.Bonus;
                }

                return totalBonus;
            }
            set
            {
                int totalBonus = value;
                int bonusForEmployee = totalBonus / m_Employees.Count;
                int leftOverBonus = totalBonus % m_Employees.Count;

                foreach (ICompanyUnit employee in Employees)
                {
                    employee.Bonus = bonusForEmployee + leftOverBonus;
                    leftOverBonus = 0;
                }
            }
        }

        void ICompanyUnit.Stats()
        {
            foreach (ICompanyUnit employee in Employees)
            {
                employee.Stats();
            }
        }

        #endregion
    }
}
