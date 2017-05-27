using System;
using System.Collections.Generic;

using DesignPatterns.Behavioral.Command.Commands;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Invoker Class
    /// </summary>
    internal class User
    {
        //################################################################################
        #region Fields

        private readonly List<ICommand> m_CommandList;
        private int m_CurrentLevel;

        #endregion

        //################################################################################
        #region Constructor

        public User()
        {
            m_CommandList = new List<ICommand>();
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void ExecuteCommand(ICommand command)
        {
            //Execute command
            command.Execute();

            //Add command to the command list
            m_CommandList.Add(command);
            m_CurrentLevel++;
        }

        internal void Undo(int levels)
        {
            Console.WriteLine($"\n--> UNDO {levels} levels.");

            for (int i = 0; i < levels; i++)
            {
                if (m_CurrentLevel == 0)
                {
                    break;
                }

                m_CurrentLevel--;
                m_CommandList[m_CurrentLevel].Undo();
            }
        }

        internal void Redo(int levels)
        {
            Console.WriteLine($"\n--> REDO {levels} levels.");

            for (int i = 0; i < levels; i++)
            {
                if (m_CurrentLevel == m_CommandList.Count)
                {
                    break;
                }

                m_CommandList[m_CurrentLevel].Execute();
                m_CurrentLevel++;
            }
        }

        #endregion
    }
}
