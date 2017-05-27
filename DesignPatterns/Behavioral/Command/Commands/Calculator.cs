using System;

namespace DesignPatterns.Behavioral.Command.Commands
{
    /// <summary>
    /// Receiver class
    /// </summary>
    internal class Calculator
    {
        //################################################################################
        #region Fields

        private int m_CurrentValue;

        #endregion

        //################################################################################
        #region Constructor

        public Calculator(int initialValue)
        {
            m_CurrentValue = initialValue;
            Console.WriteLine($"Initial Value: {m_CurrentValue}\n");
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void Operation(char @operator, int operand)
        {
            int tempValue = m_CurrentValue;

            switch (@operator)
            {
                case '+':
                    tempValue += operand;
                    break;

                case '-':
                    tempValue -= operand;
                    break;

                case '*':
                    tempValue *= operand;
                    break;

                case '/':
                    tempValue /= operand;
                    break;

                default:
                    throw new ArgumentException("Invalid operator.");
            }

            Console.WriteLine($"{m_CurrentValue} {@operator} {operand} = {tempValue}");

            m_CurrentValue = tempValue;
        }

        #endregion
    }
}
