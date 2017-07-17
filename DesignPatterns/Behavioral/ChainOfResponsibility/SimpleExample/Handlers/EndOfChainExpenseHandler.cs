using System;

using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Handlers
{
    /// <summary>
    /// Singleton pattern is applied
    /// </summary>
    internal class EndOfChainExpenseHandler : IExpenseHandler
    {
        //################################################################################
        #region Fields

        private static readonly EndOfChainExpenseHandler s_Instance = new EndOfChainExpenseHandler();

        #endregion

        //################################################################################
        #region Constructor

        private EndOfChainExpenseHandler()
        {

        }

        #endregion

        //################################################################################
        #region Properties

        public static EndOfChainExpenseHandler Instance => s_Instance;

        #endregion

        //################################################################################
        #region IExpenseHandler Implementation

        ApprovalResponse IExpenseHandler.Approve(IExpenseReport expenseReport, out string approverName)
        {
            approverName = string.Empty;
            return ApprovalResponse.Denied;
        }

        void IExpenseHandler.RegisterNext(IExpenseHandler nextHandler)
        {
            throw new InvalidOperationException("End of chain handler must the end of chain.");
        }

        #endregion
    }
}
