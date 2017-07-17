using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Approvers
{
    public interface IExpenseApprover
    {
        string Name { get; }

        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }
}
