using System;

using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// "Concrete Visitor"
    /// </summary>
    internal class PrintVisitor : IVisitor
    {
        void IVisitor.Visit(IEmployee employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Employee Type: {employee.ToString()}");
            Console.WriteLine($"Employee Income: {employee.Income}");
            Console.WriteLine($"Employee Vacation Days: {employee.VacationDays}");
            Console.WriteLine("- - - - -");
        }
    }
}
