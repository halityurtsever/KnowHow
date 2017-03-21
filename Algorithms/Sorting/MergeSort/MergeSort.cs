using CodeHelpers;
using System;

namespace Algorithms.Sorting.MergeSort
{
    /** Merge sort algorithm
     * Divide an unsorted list recursively until each list has only one element.
     * Then merge all divided list by producing a new sorted list.
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Divide left array  -> 7 - 3 - 9 - 5 - 2   8 - 6 - 1 - 4
     *                       ^---------------^
     * 
     * Divide left array  -> 7 - 3 - 9   5 - 2   8 - 6 - 1 - 4
     *                       ^-------^   ^---^
     * 
     * Divide left array  -> 7 - 3   9   5   2   8 - 6 - 1 - 4
     *                       ^---^   ^   ^   ^
     * 
     * Divide left array  -> 7   3   9   5   2   8 - 6 - 1 - 4
     *                       ^   ^   ^   ^   ^
     * 
     * Merge left array   -> 3 - 7   9   5   2   8 - 6 - 1 - 4
     *                       ^---^   ^   ^   ^
     * 
     * Merge left array   -> 3 - 7 - 9   5   2   8 - 6 - 1 - 4
     *                       ^-------^   ^   ^
     * 
     * Merge left array   -> 3 - 7 - 9   2 - 5   8 - 6 - 1 - 4
     *                       ^-------^   ^---^
     * 
     * Merge left array   -> 2 - 3 - 5 - 7 - 9   8 - 6 - 1 - 4
     *                       ^---------------^
     * 
     * Divide right array -> 2 - 3 - 5 - 7 - 9   8 - 6   1 - 4
     *                                           ^---^   ^---^
     * 
     * Divide right array -> 2 - 3 - 5 - 7 - 9   8   6   1   4
     *                                           ^   ^   ^   ^
     * 
     * Merge right array  -> 2 - 3 - 5 - 7 - 9   6 - 8   1   4
     *                                           ^---^   ^   ^
     * 
     * Merge right array  -> 2 - 3 - 5 - 7 - 9   6 - 8   1 - 4
     *                                           ^---^   ^---^
     * 
     * Merge right array  -> 2 - 3 - 5 - 7 - 9   1 - 4 - 6 - 8
     *                                           ^-----------^
     * 
     * Merge all array    -> 2 - 3 - 5 - 7 - 9   1 - 4 - 6 - 8
     *                       ^---------------^   ^-----------^
     * 
     * Sorted array       -> 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9
     * 
     * Worst case performance: O(n log(n))
     * Best case performance: O(n log(n)) typical, O(n) natural variant
     * Average performance: O(n log(n))
     * Worst case space complexity: O(n) total, O(n) auxiliary
     * 
     */

    public class MergeSort
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;

        #endregion

        //################################################################################
        #region Constructor

        public MergeSort(int[] array)
        {
            m_Array = array;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        public void Sort()
        {
            var left = 0;
            var right = m_Array.Length - 1;

            Sort(m_Array, left, right);
        }

        public void TraceSort(Tracer tracer)
        {
            throw new NotImplementedException();
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void Sort(int[] array, int left, int right)
        {
            var difference = right - left;
            var middle = (right + left) / 2;

            if (left == right)
            {
                return;
            }

            if (difference >= 1)
            {
                //sort left part
                Sort(array, left, middle);

                //sort right part
                Sort(array, middle + 1, right);
            }

            Merge(array, left, middle, right);
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            //create temp array
            int[] tempArray = new int[right - left + 1];

            int leftArrayIndex = left;
            int rightArrayIndex = middle + 1;
            int tempIndex = 0;

            while (tempIndex < tempArray.Length)
            {
                //left or right array reached to end of the array
                if (leftArrayIndex > middle || rightArrayIndex > right)
                {
                    break;
                }

                if (array[leftArrayIndex] > array[rightArrayIndex])
                {
                    tempArray[tempIndex] = array[rightArrayIndex];
                    rightArrayIndex++;
                }
                else
                {
                    tempArray[tempIndex] = array[leftArrayIndex];
                    leftArrayIndex++;
                }

                tempIndex++;
            }

            //if any index left from left side
            if (leftArrayIndex <= middle)
            {
                for (int i = leftArrayIndex; i <= middle; i++)
                {
                    tempArray[tempIndex] = array[i];
                    tempIndex++;
                }
            }

            //if any index left from right side
            if (rightArrayIndex <= right)
            {
                for (int i = rightArrayIndex; i <= right; i++)
                {
                    tempArray[tempIndex] = array[i];
                    tempIndex++;
                }
            }

            //copy temp array to real array
            Array.Copy(tempArray, 0, array, left, tempArray.Length);
        }

        #endregion
    }
}
