using System;
using System.Collections.Generic;

namespace Concepts.AsyncAwait_Sample.RaceConditionWithSolution
{
    class RaceCondition_Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var operator_1 = new Operator($"oprt{i}", 1000);
                operator_1.PrintListToFile();
            }

            Console.WriteLine("Finished.");
        }
    }
}
