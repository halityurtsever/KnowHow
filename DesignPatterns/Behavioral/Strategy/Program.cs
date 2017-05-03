using System;

using DesignPatterns.Behavioral.Strategy.SortStrategy;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            //bubble sort
            sortedList.List = new[] { 9, 3, 6, 1, 5, 8, 2, 7 };
            sortedList.SortStrategy = new BubbleSortStrategy();
            sortedList.Sort();

            //selection sort
            sortedList.List = new[] { 12, 65, 34, 45, 98, 56, 41, 76 };
            sortedList.SortStrategy = new SelectionSortStrategy();
            sortedList.Sort();

            //insertion sort
            sortedList.List = new[] { 78, 82, 39, 15, 53, 66, 21, 17 };
            sortedList.SortStrategy = new InsertionSortStrategy();
            sortedList.Sort();

            //merge sort
            sortedList.List = new[] { 926, 515, 856, 142, 917, 721, 873, 319, 480 };
            sortedList.SortStrategy = new MergeSortStrategy();
            sortedList.Sort();

            Console.ReadLine();
        }
    }
}
