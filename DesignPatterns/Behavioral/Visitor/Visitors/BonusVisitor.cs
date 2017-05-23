using System;

using DesignPatterns.Behavioral.Visitor.Elements;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    class BonusVisitor : IVisitor
    {
        void IVisitor.Visit(Employee employee)
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
