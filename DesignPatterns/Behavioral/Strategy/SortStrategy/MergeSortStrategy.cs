using Algorithms.Sorting.MergeSort;

namespace DesignPatterns.Behavioral.Strategy.SortStrategy
{
    internal class MergeSortStrategy : ISortStrategy
    {
        //################################################################################
        #region ISortStrategy Implementation

        void ISortStrategy.Sort(int[] unsortedList)
        {
            MergeSort mergeSortAlgorithm = new MergeSort(unsortedList);
            mergeSortAlgorithm.Sort();
        }

        #endregion

        //################################################################################
        #region Overrides

        public override string ToString()
        {
            return "Merge Sort";
        }

        #endregion
    }
}
