using Algorithms.Sorting.SelectionSort;

namespace DesignPatterns.Behavioral.Strategy.SortStrategy
{
    internal class SelectionSortStrategy : ISortStrategy
    {
        //################################################################################
        #region ISortStrategy Implementation

        void ISortStrategy.Sort(int[] unsortedList)
        {
            SelectionSort selectionSortAlgorithm = new SelectionSort(unsortedList);
            selectionSortAlgorithm.Sort();
        }

        #endregion

        //################################################################################
        #region Overrides

        public override string ToString()
        {
            return "Selection Sort";
        }

        #endregion
    }
}
