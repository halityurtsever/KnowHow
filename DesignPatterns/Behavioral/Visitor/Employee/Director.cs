
using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Employee
{
    internal class Director : IEmployee
    {
        //################################################################################
        #region Fields

        private string m_Name;
        private double m_Income;
        private int m_VacationDays;

        #endregion

        //################################################################################
        #region Constructor

        public Director(string name, double income, int vacationDays)
        {
            m_Name = name;
            m_Income = income;
            m_VacationDays = vacationDays;
        }

        #endregion

        //################################################################################
        #region IEmployee Implementation

        string IEmployee.Name { get => m_Name; }

        double IEmployee.Income
        {
            get => m_Income;
            set => m_Income = value;
        }

        int IEmployee.VacationDays
        {
            get => m_VacationDays;
            set => m_VacationDays = value;
        }

        void IEmployee.Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion

        //################################################################################
        #region Overrides

        public override string ToString()
        {
            return "Director";
        }

        #endregion
    }
}
