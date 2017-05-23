
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Elements
{
    internal class Employee : Element
    {
        //################################################################################
        #region Fields

        private string m_Name;
        private double m_Income;
        private int m_VacationDays;

        #endregion

        //################################################################################
        #region Constructor

        public Employee(string name, double income, int vacationDays)
        {
            m_Name = name;
            m_Income = income;
            m_VacationDays = vacationDays;
        }

        #endregion

        //################################################################################
        #region Properties

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public double Income
        {
            get
            {
                return m_Income;
            }

            set
            {
                m_Income = value;
            }
        }

        public int VacationDays
        {
            get
            {
                return m_VacationDays;
            }

            set
            {
                m_VacationDays = value;
            }
        }

        #endregion

        //################################################################################
        #region Overrides

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion
    }
}
