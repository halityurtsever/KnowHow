using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Handlers
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport, out string approverName);

        void RegisterNext(IExpenseHandler nextHandler);
    }
}
