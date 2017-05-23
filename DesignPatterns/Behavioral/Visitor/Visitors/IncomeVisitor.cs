using System;

using DesignPatterns.Behavioral.Visitor.Elements;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// "Concrete Visitor"
    /// </summary>
    internal class IncomeVisitor : IVisitor
    {
        void IVisitor.Visit(Element element)
        {
            Employee employee = element as Employee;

            //Provide 10% pay raise
            if (employee != null)
            {
                employee.Income *= 1.10;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income}");
            }
        }
    }
}
