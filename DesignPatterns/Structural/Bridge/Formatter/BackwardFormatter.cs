using System.Linq;

namespace DesignPatterns.Structural.Bridge.Formatter
{
    internal class BackwardFormatter : IFormatter
    {
        //################################################################################
        #region IFormatter Implementation

        string IFormatter.Format(string title, string detail)
        {
            return $"{new string(title.Reverse().ToArray())}: {new string(detail.Reverse().ToArray())}";
        }

        #endregion
    }
}
