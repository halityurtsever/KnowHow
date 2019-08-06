using System;

using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// "Concrete Visitor"
    /// </summary>
    internal class IncomeVisitor : IVisitor
    {
        void IVisitor.Visit(IEmployee employee)
        {
            //Provide 10% pay raise
            if (employee != null)
            {
                employee.Income *= 1.10;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income}");
            }
        }
    }
}
