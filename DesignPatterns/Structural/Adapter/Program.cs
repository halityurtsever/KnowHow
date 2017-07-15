using System;

namespace DesignPatterns.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter(new Adaptee());
            Client client = new Client(adapter);

            foreach (var name in client.GetNamesOverAdapter())
            {
                Console.WriteLine(name);
            }
        }
    }
}
