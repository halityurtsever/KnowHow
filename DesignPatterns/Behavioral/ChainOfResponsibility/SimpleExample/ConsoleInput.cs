using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.SimpleExample
{
    public static class ConsoleInput
    {
        public static bool TryReadDecimal(string prompt, out decimal value)
        {
            value = default(decimal);

            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) return false;

                try
                {
                    value = Convert.ToDecimal(input);
                    return true;
                }
                catch(Exception)
                {
                    Console.WriteLine("Not a valid decimal input.");
                }
            }
        }
    }
}
