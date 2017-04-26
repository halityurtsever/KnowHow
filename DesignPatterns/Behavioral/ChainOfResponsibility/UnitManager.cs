﻿using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// "Concrete Handler" class
    /// </summary>
    internal class UnitManager : Approver
    {
        //################################################################################
        #region Constructor

        public UnitManager(string name) : base(name)
        {
        }

        #endregion

        //################################################################################
        #region Approver Overrides

        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Price <= 75000)
            {
                Console.WriteLine($"Purchase is approved by unit manager {this.Name} with amount of {purchase.Amount} for price {purchase.Price}.");
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
