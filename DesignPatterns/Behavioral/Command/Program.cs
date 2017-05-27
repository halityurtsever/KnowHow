using System;

using DesignPatterns.Behavioral.Command.Commands;

namespace DesignPatterns.Behavioral.Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.ExecuteCommand(new CalculateCommand('+', 500));
            user.ExecuteCommand(new CalculateCommand('-', 100));
            user.ExecuteCommand(new CalculateCommand('/', 2));
            user.ExecuteCommand(new CalculateCommand('*', 5));

            user.Undo(3);
            user.Redo(2);

            Console.ReadLine();
        }
    }
}
