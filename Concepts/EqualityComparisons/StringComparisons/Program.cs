using System;
using System.Globalization;
using System.Threading;

namespace StringComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            //English (United States), German (Germany), Sami (Northern) (Sweden), Turkish (Turkey)
            string[] cultureNames = { "en-US", "de-DE", "se-SE", "tr-TR" };
            string[] values_1 = { "same", "case", "ausser", "encyclopædia", "encyclopædia", "Archæology" };
            string[] values_2 = { "same", "Case", "außer", "encyclopaedia", "encyclopedia", "ARCHÆOLOGY" };

            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            Console.WriteLine($"Original Culture: {CultureInfo.CurrentCulture.Name}");

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine($"Current Culture: {CultureInfo.CurrentCulture.Name}");

                foreach (var comparison in comparisons)
                {
                    Console.WriteLine($"\t({comparison})\n\t---");
                    for (int i = 0; i < values_1.Length; i++)
                    {
                        Console.WriteLine($"\t{values_1[i]} = {values_2[i]} : {string.Equals(values_1[i], values_2[i], comparison)}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
