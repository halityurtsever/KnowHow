using System;

using DesignPatterns.Behavioral.Command.Commands;

namespace DesignPatterns.Behavioral.Command
{
    public class Program
    {
        static void Main()
        {
            User user = new User();
            Calculator calculator = new Calculator();

            user.Compute(new AddCommand(calculator, 56, 89));
            user.Compute(new MultiplyCommand(calculator, 67, 59));

            Console.ReadLine();
        }
    }
}
