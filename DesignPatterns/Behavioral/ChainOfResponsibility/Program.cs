using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver halit = new Director("Halit Yurtsever");
            Approver aysun = new UnitManager("Aysun Yurtsever");
            Approver yigit = new ProjectManager("Yiğit Ali Yurtsever");

            yigit.SetSuccessor(aysun);
            aysun.SetSuccessor(halit);

            Purchase purchase_1 = new Purchase(100, 40000);
            Purchase purchase_2 = new Purchase(200, 60000);
            Purchase purchase_3 = new Purchase(300, 80000);
            Purchase purchase_4 = new Purchase(400, 120000);

            yigit.ProcessRequest(purchase_1);
            //output:
            //Purchase is approved by project manager Yiğit Ali Yurtsever with amount of 100 for price 40000.


            yigit.ProcessRequest(purchase_2);
            //output:
            //Purchases for prices more than 60000 require escalation to upper manager.
            //Purchase is approved by unit manager Aysun Yurtsever with amount of 200 for price 60000.


            yigit.ProcessRequest(purchase_3);
            //output:
            //Purchases for prices more than 80000 require escalation to upper manager.
            //Purchases for prices more than 80000 require escalation to upper manager.
            //Purchase is approved by director Halit Yurtsever with amount of 300 for price 80000.


            yigit.ProcessRequest(purchase_4);
            //output:
            //Purchases for prices more than 120000 require escalation to upper manager.
            //Purchases for prices more than 120000 require escalation to upper manager.
            //Purchases for prices more than 120000 require executive meeting.

            Console.ReadLine();
        }
    }
}
