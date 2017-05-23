using System;

using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();

            employees.Attach(new Clark("Yiğit Ali", 2000, 365));
            employees.Attach(new Director("Aysun", 4000, 180));
            employees.Attach(new President("Halit", 8000, 50));

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
            employees.Accept(new BonusVisitor());

            Console.ReadLine();
        }
    }
}
