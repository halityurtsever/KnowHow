using Algorithms.Sorting.BubbleSort;

namespace DesignPatterns.Behavioral.Strategy.SortStrategy
{
    internal class BubbleSortStrategy : ISortStrategy
    {
        //################################################################################
        #region ISortStrategy Implementation

        void ISortStrategy.Sort(int[] unsortedList)
        {
            BubbleSort bubbleSortAlgorithm = new BubbleSort(unsortedList);
            bubbleSortAlgorithm.Sort();
        }

        #endregion

        //################################################################################
        #region Overrides

        public override string ToString()
        {
            return "Bubble Sort";
        }

        #endregion
    }
}
