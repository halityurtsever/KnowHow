
namespace DesignPatterns.Behavioral.Command
{
    internal class Calculator
    {
        //################################################################################
        #region Fields

        private double m_CurrentValue;

        #endregion

        //################################################################################
        #region Constructor

        public Calculator()
        {
            m_CurrentValue = 0;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal double Add(double firstOperand, double secondOperand)
        {
            m_CurrentValue = firstOperand + secondOperand;
            return m_CurrentValue;
        }

        internal double Substract(double firstOperand, double secondOperand)
        {
            m_CurrentValue = firstOperand - secondOperand;
            return m_CurrentValue;
        }

        internal double Divide(double firstOperand, double secondOperand)
        {
            m_CurrentValue = firstOperand / secondOperand;
            return m_CurrentValue;
        }

        internal double Multiply(double firstOperand, double secondOperand)
        {
            m_CurrentValue = firstOperand * secondOperand;
            return m_CurrentValue;
        }

        #endregion
    }
}
