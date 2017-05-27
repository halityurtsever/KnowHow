using System;

namespace DesignPatterns.Behavioral.Command.Commands
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    internal class CalculateCommand : ICommand
    {
        //################################################################################
        #region Fields

        private readonly char m_Operator;
        private readonly int m_Operand;
        private readonly Calculator m_Calculator;

        #endregion

        //################################################################################
        #region Constructor

        public CalculateCommand(char @operator, int operand)
        {
            m_Operator = @operator;
            m_Operand = operand;
            m_Calculator = new Calculator(0);
        }

        #endregion

        //################################################################################
        #region ICommand Implementation

        void ICommand.Execute()
        {
            m_Calculator.Operation(m_Operator, m_Operand);
        }

        void ICommand.Undo()
        {
            m_Calculator.Operation(Undo(m_Operator), m_Operand);
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';

                case '-':
                    return '+';

                case '*':
                    return '/';

                case '/':
                    return '*';

                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }

        #endregion
    }
}
