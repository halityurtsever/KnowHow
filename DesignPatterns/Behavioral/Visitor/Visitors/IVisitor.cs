
using DesignPatterns.Behavioral.Visitor.Elements;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// the "Visitor" interface
    /// </summary>
    internal interface IVisitor
    {
        void Visit(Employee employee);
    }
}
