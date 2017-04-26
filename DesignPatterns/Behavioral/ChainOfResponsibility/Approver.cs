namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// "Handler" class
    /// </summary>
    internal abstract class Approver
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private Approver m_Successor;

        #endregion

        //################################################################################
        #region Constructor

        protected Approver(string name)
        {
            this.m_Name = name;
        }

        #endregion

        //################################################################################
        #region Properties

        protected Approver Successor => this.m_Successor;

        internal string Name => this.m_Name;

        #endregion

        //################################################################################
        #region Abstract Methods

        public abstract void ProcessRequest(Purchase purchase);

        #endregion

        //################################################################################
        #region Public Implementation

        public void SetSuccessor(Approver successor)
        {
            this.m_Successor = successor;
        }

        #endregion
    }
}
