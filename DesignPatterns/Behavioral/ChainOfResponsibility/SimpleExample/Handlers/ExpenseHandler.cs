using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Approvers;
using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Handlers
{
    internal class ExpenseHandler : IExpenseHandler
    {
        //################################################################################
        #region Fields

        private readonly IExpenseApprover m_Approver;
        private IExpenseHandler m_NextHandler;

        #endregion

        //################################################################################
        #region Constructor

        public ExpenseHandler(IExpenseApprover approver)
        {
            m_Approver = approver;
            m_NextHandler = EndOfChainExpenseHandler.Instance;
        }

        #endregion

        //################################################################################
        #region IExpenseHandler Implementation

        ApprovalResponse IExpenseHandler.Approve(IExpenseReport expenseReport, out string approverName)
        {
            approverName = m_Approver.Name;
            var response = m_Approver.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return m_NextHandler.Approve(expenseReport, out approverName);
            }

            return response;
        }

        void IExpenseHandler.RegisterNext(IExpenseHandler nextHandler)
        {
            m_NextHandler = nextHandler;
        }

        #endregion
    }
}
