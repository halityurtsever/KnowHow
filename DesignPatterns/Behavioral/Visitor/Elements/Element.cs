
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Elements
{
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
