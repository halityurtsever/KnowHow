using System;
using System.Collections.Generic;

using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor
{
    internal class Employees
    {
        //################################################################################
        #region Fields

        private readonly IList<IEmployee> m_Employees = new List<IEmployee>();

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void Attach(IEmployee employee)
        {
            m_Employees.Add(employee);
        }

        internal void Detach(IEmployee employee)
        {
            m_Employees.Remove(employee);
        }

        internal void Accept(IVisitor visitor)
        {
            Console.WriteLine(visitor.GetType());
            foreach (IEmployee employee in m_Employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }

        #endregion
    }
}
