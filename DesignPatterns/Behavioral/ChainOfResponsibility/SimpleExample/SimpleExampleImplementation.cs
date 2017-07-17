using System;

using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Approvers;
using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Handlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample
{
    public static class SimpleExampleImplementation
    {
        public static void Execute()
        {
            IExpenseHandler YigitAli = new ExpenseHandler(new Employee("Yiğit Ali", 500));
            IExpenseHandler Aysun = new ExpenseHandler(new Employee("Aysun", 1000));
            IExpenseHandler Halit = new ExpenseHandler(new Employee("Halit", 10000));

            YigitAli.RegisterNext(Aysun);
            Aysun.RegisterNext(Halit);

            decimal expenseReportAmount;
            if (ConsoleInput.TryReadDecimal("Expense report amount: ", out expenseReportAmount))
            {
                string approverName;
                IExpenseReport expenseReport = new ExpenseReport(expenseReportAmount);
                ApprovalResponse response = YigitAli.Approve(expenseReport, out approverName);

                string approvedBy = !string.IsNullOrEmpty(approverName) ? $" by {approverName}." : ".";
                Console.WriteLine($"The request was {response}{approvedBy}");
            }
        }
    }
}
