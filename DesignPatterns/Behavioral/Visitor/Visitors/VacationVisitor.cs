using System;

using DesignPatterns.Behavioral.Visitor.Elements;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// "Concrete Visitor"
    /// </summary>
    internal class VacationVisitor : IVisitor
    {
        void IVisitor.Visit(Employee employee)
        {
            if (employee != null)
            {
                //Provide 3 extra vacation days
                employee.VacationDays += 3;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
            }
        }
    }
}
