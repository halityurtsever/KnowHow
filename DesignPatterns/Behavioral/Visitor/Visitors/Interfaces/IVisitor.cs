
using DesignPatterns.Behavioral.Visitor.Employee.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Visitors.Interfaces
{
    /// <summary>
    /// the "Visitor" interface
    /// </summary>
    internal interface IVisitor
    {
        void Visit(IEmployee employee);
    }
}
