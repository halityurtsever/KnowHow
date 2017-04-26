using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// "Concrete Handler" class
    /// </summary>
    internal class Director : Approver
    {
        //################################################################################
        #region Constructor

        public Director(string name) : base(name)
        {
        }

        #endregion

        //################################################################################
        #region Approver Overrides

        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Price <= 100000)
            {
                Console.WriteLine($"Purchase is approved by director {this.Name} with amount of {purchase.Amount} for price {purchase.Price}.");
            }
            else
            {
                Console.WriteLine($"Purchases for prices more than {purchase.Price} require executive meeting.");
            }
        }

        #endregion
    }
}
