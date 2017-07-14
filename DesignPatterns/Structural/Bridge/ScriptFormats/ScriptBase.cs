using DesignPatterns.Structural.Bridge.Formatter;

namespace DesignPatterns.Structural.Bridge.ScriptFormats
{
    public abstract class ScriptBase
    {
        //################################################################################
        #region Fields

        protected readonly IFormatter m_Formatter;

        #endregion

        //################################################################################
        #region Constructor

        protected ScriptBase(IFormatter formatter)
        {
            m_Formatter = formatter;
        }

        #endregion

        //################################################################################
        #region Abstract Members

        public abstract void Print();

        #endregion
    }
}
