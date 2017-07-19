using System;

namespace DesignPatterns.Behavioral.Command.Commands
{
    internal class SubstractCommand : ICommand
    {
        //################################################################################
        #region Fields

        private readonly Calculator m_Calculator;
        private readonly double m_FirstOperand;
        private readonly double m_SecondOperand;

        #endregion

        //################################################################################
        #region Constructor

        public SubstractCommand(Calculator calculator, double firstOperand, double secondOperand)
        {
            m_Calculator = calculator;
            m_FirstOperand = firstOperand;
            m_SecondOperand = secondOperand;
        }

        #endregion

        //################################################################################
        #region ICommand Implementation

        void ICommand.Execute()
        {
            var result = m_Calculator.Substract(m_FirstOperand, m_SecondOperand);

            Console.WriteLine($"Result of substraction: {m_FirstOperand} - {m_SecondOperand} = {result}");
        }

        #endregion
    }
}
