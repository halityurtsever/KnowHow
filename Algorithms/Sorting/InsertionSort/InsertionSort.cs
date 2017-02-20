﻿using CodeHelpers;

namespace Algorithms.Sorting.InsertionSort
{
    /** Insertion sort algorithm
     * Compares xth element of an array with previous indexes until find a smaller one
     * Then it shifts biggers to right until the smaller one then insert the xth element to new place in the array
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Pass 1             -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     *                       ^
     *                       insert 3 before 7, shift other elements to right
     * 
     * Pass 2             -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     *                               ^
     *                               9 remains because it is bigger than 7
     * 
     * Pass 3             -> 3 - 5 - 7 - 9 - 2 - 8 - 6 - 1 - 4
     *                           ^
     *                           insert 5 before 7, shift other elements to right
     * 
     * Pass 4             -> 2 - 3 - 5 - 7 - 9 - 8 - 6 - 1 - 4
     *                       ^
     *                       insert 2 before 3, shift other elements to right
     * and goes on...
     * 
     * Worst case performance: O(n2) comparisons, swaps
     * Best case performance: O(n) comparisons, O(1) swaps
     * Average performance: O(n2) comparisons, swaps
     * Worst case space complexity: O(n) total, O(1) auxiliary
     * 
     */

    public class InsertionSort
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;

        #endregion

        //################################################################################
        #region Constructor

        public InsertionSort(int[] array)
        {
            m_Array = array;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        /// <summary>
        /// Iterates an array and inserts smaller values until it founds a bigger one
        /// then shifts all biggers to right
        /// </summary>
        public void Sort()
        {
            for (int i = 1; i < m_Array.Length; i++)
            {
                var index = i;
                while (index > 0)
                {
                    if (m_Array[index] < m_Array[index - 1])
                    {
                        var temp = m_Array[index - 1];
                        m_Array[index - 1] = m_Array[index];
                        m_Array[index] = temp;
                    }
                    index--;

                }
            }
        }

        public void TraceSort(Tracer tracer)
        {
#if TRACE
            tracer.CurrentArray(m_Array);
            var insertCount = 0;
#endif
            for (int i = 1; i < m_Array.Length; i++)
            {
                var index = i;
                while (index > 0)
                {
                    if (m_Array[index] < m_Array[index - 1])
                    {
                        var temp = m_Array[index - 1];
                        m_Array[index - 1] = m_Array[index];
                        m_Array[index] = temp;
                    }
                    index--;
#if TRACE
                    //Current status of the array
                    tracer.CurrentArray(m_Array);
                    insertCount++;
#endif
                }
            }
#if TRACE
            tracer.WriteOutput($"TOTAL INSERT COUNT: {insertCount}");
#endif
        }

        #endregion
    }
}
