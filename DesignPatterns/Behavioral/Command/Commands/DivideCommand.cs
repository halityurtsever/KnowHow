﻿using System;

namespace DesignPatterns.Behavioral.Command.Commands
{
    internal class DivideCommand : ICommand
    {
        //################################################################################
        #region Fields

        private readonly Calculator m_Calculator;
        private readonly double m_FirstOperand;
        private readonly double m_SecondOperand;

        #endregion

        //################################################################################
        #region Constructor

        public DivideCommand(Calculator calculator, double firstOperand, double secondOperand)
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
            var result = m_Calculator.Divide(m_FirstOperand, m_SecondOperand);

            Console.WriteLine($"Result of division: {m_FirstOperand} / {m_SecondOperand} = {result}");
        }

        #endregion
    }
}
