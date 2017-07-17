using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Approvers
{
    internal class Employee : IExpenseApprover
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private readonly decimal m_ApproveLimit;

        #endregion

        //################################################################################
        #region Constructor

        public Employee(string name, decimal approveLimit)
        {
            m_Name = name;
            m_ApproveLimit = approveLimit;
        }

        #endregion

        //################################################################################
        #region IExpenseApprover Implementation

        string IExpenseApprover.Name => m_Name;

        ApprovalResponse IExpenseApprover.ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > m_ApproveLimit
                       ? ApprovalResponse.BeyondApprovalLimit
                       : ApprovalResponse.Approved;
        }

        #endregion
    }
}
