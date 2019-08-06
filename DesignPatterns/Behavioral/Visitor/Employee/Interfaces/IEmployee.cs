
using DesignPatterns.Behavioral.Visitor.Visitors.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Employee.Interfaces
{
    internal interface IEmployee
    {
        //################################################################################
        #region Properties

        string Name { get; }

        double Income { get; set; }

        int VacationDays { get; set; }

        #endregion

        //################################################################################
        #region Methods

        void Accept(IVisitor visitor);

        #endregion
    }
}
