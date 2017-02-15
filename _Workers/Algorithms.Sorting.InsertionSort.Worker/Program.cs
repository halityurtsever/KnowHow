using System;
using CodeHelpers;
using TestHelpers;

namespace Algorithms.Sorting.InsertionSort.Worker
{
    public class Program
    {
        //################################################################################
        #region Public Implementation

        public static void Main()
        {
            MeasureTimeComplexity(10, true);
            MeasureTimeComplexity(50, true);
            MeasureTimeComplexity(100, false);
            MeasureTimeComplexity(1000, false);

            Console.WriteLine("DONE...");
            Console.ReadLine();
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private static void MeasureTimeComplexity(int arraySize, bool isLogFile)
        {
            Tracer tracer = new Tracer(OutputType.NoneUI, isLogFile);
            var elapsedTime = string.Empty;
            var reverseInsertionSort = new InsertionSort(new IntArrayGenerator(arraySize).GetReversed());
            var unsortedInsertionSort = new InsertionSort(new IntArrayGenerator(arraySize).GetUnsorted());

            tracer.WriteOutput($"INSERTION SORT");
            tracer.WriteOutput($"REVERSED ARRAY");
            tracer.StartTimer();
            reverseInsertionSort.TraceSort(tracer);
            elapsedTime = tracer.StopTimer();

            tracer.WriteOutput($"Array Size: {arraySize}");
            tracer.WriteOutput($"Array Type: Reversed");
            tracer.WriteOutput($"Time Complexity: {elapsedTime}");
            tracer.WriteOutput(Environment.NewLine);

            tracer.WriteOutput($"UNSORTED ARRAY");
            tracer.StartTimer();
            unsortedInsertionSort.TraceSort(tracer);
            elapsedTime = tracer.StopTimer();

            tracer.WriteOutput($"Array Size: {arraySize}");
            tracer.WriteOutput($"Array Type: Unsorted");
            tracer.WriteOutput($"Time Complexity: {elapsedTime}");
            tracer.WriteOutput(Environment.NewLine);
        }

        #endregion
    }
}
