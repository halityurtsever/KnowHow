using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// "Concrete Handler" class
    /// </summary>
    internal class ProjectManager : Approver
    {
        //################################################################################
        #region Constructor

        public ProjectManager(string name) : base(name)
        {
        }

        #endregion

        //################################################################################
        #region Approver Overrides

        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Price <= 50000)
            {
                Console.WriteLine($"Purchase is approved by project manager {this.Name} with amount of {purchase.Amount} for price {purchase.Price}.");
            }
            else
            {
                Console.WriteLine($"Purchases for prices more than {purchase.Price} require escalation to upper manager.");
                this.Successor.ProcessRequest(purchase);
            }
        }

        #endregion
    }
}
