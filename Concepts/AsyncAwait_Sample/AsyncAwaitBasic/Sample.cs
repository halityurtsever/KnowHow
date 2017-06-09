using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Concepts.AsyncAwait_Sample.AsyncAwaitBasic
{
    internal class Sample
    {
        //################################################################################
        #region Fields

        private const int Min = 100;
        private const int Count = 1000;

        #endregion

        //################################################################################
        #region Synchronous Implementation

        internal void PrintPrimeNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                var result = GetPrimeNumbers(i * Min + 1, i * Count);
                result.ToList().ForEach(x => PrintToFile("sync.txt", x));
            }
        }

        private IEnumerable<int> GetPrimeNumbers(int min, int count)
        {
            return GetPrimeNumbersInSpecificRange(min, count);
        }

        #endregion

        //################################################################################
        #region Asynchronous Implementation

        internal async void PrintPrimeNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                //Process doesn't wait for return value, continue its execution
                //GetPrimeNumbersAsync() method will continue its work in another thread
                var result = await GetPrimeNumbersAsync(i * Min + 1, i * Count);

                //After result has been gathered, each item in the list will be printed to the file.
                result.ToList().ForEach(x => PrintToFile("async.txt", x));
            }
        }

        private Task<IEnumerable<int>> GetPrimeNumbersAsync(int min, int count)
        {
            return Task.Run(() => GetPrimeNumbersInSpecificRange(min, count));
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private IEnumerable<int> GetPrimeNumbersInSpecificRange(int min, int count)
        {
            return Enumerable.Range(min, count)
                             .Where(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1)
                                                   .All(i => n % i > 0));
        }

        private void PrintToFile(string filename, int value)
        {
            using (StreamWriter streamWriter = File.AppendText($"C:\\tmp\\{filename}"))
            {
                streamWriter.WriteLine(value);
            }
        }

        #endregion
    }
}
