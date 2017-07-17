
namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample.Reports
{
    internal class ExpenseReport : IExpenseReport
    {
        //################################################################################
        #region Fields

        private readonly decimal m_Total;

        #endregion

        //################################################################################
        #region Constructor

        public ExpenseReport(decimal total)
        {
            m_Total = total;
        }

        #endregion

        //################################################################################
        #region IExpenseReport Implementation

        decimal IExpenseReport.Total => m_Total;

        #endregion
    }
}
