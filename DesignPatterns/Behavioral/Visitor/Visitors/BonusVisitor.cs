using System;

using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// "Concrete Visitor"
    /// </summary>
    internal class BonusVisitor : IVisitor
    {
        void IVisitor.Visit(IEmployee employee)
        {
            if (employee != null)
            {
                if (employee.VacationDays < 200)
                {
                    employee.Income += 100;
                    Console.WriteLine($"{employee.GetType().Name} {employee.Name} get 100 bonus, new income: {employee.Income}");
                }
            }
        }
    }
}
