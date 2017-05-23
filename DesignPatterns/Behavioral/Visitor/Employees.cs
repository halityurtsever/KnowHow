using System;
using System.Collections.Generic;

using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor
{
    internal class Employees
    {
        //################################################################################
        #region Fields

        private readonly IList<Employee> m_Employees = new List<Employee>();

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void Attach(Employee employee)
        {
            m_Employees.Add(employee);
        }

        internal void Detach(Employee employee)
        {
            m_Employees.Remove(employee);
        }

        internal void Accept(IVisitor visitor)
        {
            foreach (Employee employee in m_Employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }

        #endregion
    }
}
