
namespace DesignPatterns.Structural.Bridge.Formatter
{
    internal class FancyFormatter : IFormatter
    {
        //################################################################################
        #region IFormatter Implementation

        string IFormatter.Format(string title, string detail)
        {
            return $"{{=>{title}<=}}: {{=>{detail}<=}}";
        }

        #endregion
    }
}
