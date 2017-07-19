using System.Collections.Generic;

using DesignPatterns.Behavioral.Command.Commands;

namespace DesignPatterns.Behavioral.Command
{
    internal class User
    {
        //################################################################################
        #region Fields

        private readonly IList<ICommand> m_CommandList;

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

        internal void Compute(ICommand command)
        {
            m_CommandList.Add(command);
            command.Execute();
        }

        #endregion
    }
}
