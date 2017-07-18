using System;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample;
using DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Example Output:");
            SimpleExampleImplementation.Execute();

            //empty line
            Console.WriteLine();

            Console.WriteLine("Poker Example Output:");
            PokerExampleImplementation.Execute();
        }
    }
}
