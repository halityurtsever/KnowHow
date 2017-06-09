using System;

namespace AsyncAwaitBasic
{
    class Program
    {
        static void Main()
        {
            Sample sample = new Sample();

            DateTime t1 = DateTime.Now;
            Console.WriteLine("Synchronous is started.");
            sample.PrintPrimeNumbers();
            var t1_Delta = DateTime.Now.Subtract(t1);
            Console.WriteLine($"Synchronous is finished and took {t1_Delta}.");

            DateTime t2 = DateTime.Now;
            Console.WriteLine("Asynchronous is started.");
            sample.PrintPrimeNumbersAsync();
            var t2_Delta = DateTime.Now.Subtract(t2);
            Console.WriteLine($"Asynchronous is finished and took {t2_Delta}.");

            Console.ReadLine();
        }
    }
}
