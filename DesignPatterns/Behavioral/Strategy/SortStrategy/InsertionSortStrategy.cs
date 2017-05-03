using Algorithms.Sorting.InsertionSort;

namespace DesignPatterns.Behavioral.Strategy.SortStrategy
{
    internal class InsertionSortStrategy : ISortStrategy
    {
        //################################################################################
        #region ISortStrategy Implementation

        void ISortStrategy.Sort(int[] unsortedList)
        {
            InsertionSort insertionSortAlgorithm = new InsertionSort(unsortedList);
            insertionSortAlgorithm.Sort();
        }

        #endregion

        //################################################################################
        #region Overrides

        public override string ToString()
        {
            return "Insertion Sort";
        }

        #endregion
    }
}
