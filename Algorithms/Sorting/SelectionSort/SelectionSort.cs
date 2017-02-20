using CodeHelpers;

namespace Algorithms.Sorting.SelectionSort
{
    /** Selection sort algorithm
     * Finds the min number in the array and swaps it with the number in the first index
     * Then by skipping first index, again find the min number in the array and swaps it with the second index
     * and iterates recursively by skipping indexes incremently
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Pass 1             -> 1 - 3 - 9 - 5 - 2 - 8 - 6 - 7 - 4
     *                       ^---------------------------^
     *                       swap 7 and 1
     * 
     * Pass 2             -> 1 - 2 - 9 - 5 - 3 - 8 - 6 - 7 - 4
     *                           ^-----------^
     *                           skip { 1 }, swap 3 and 2
     * 
     * Pass 3             -> 1 - 2 - 3 - 5 - 9 - 8 - 6 - 7 - 4
     *                               ^-------^
     *                               skip { 1 - 2 }, swap 3 and 9
     *                               
     * Pass 4             -> 1 - 2 - 3 - 4 - 9 - 8 - 6 - 7 - 5
     *                                   ^-------------------^
     *                                   skip { 1 - 2 - 3 }, swap 4 and 5
     * 
     * and goes on...
     * 
     * Worst case performance: O(n2)
     * Best case performance: O(n)
     * Average performance: O(n2)
     * Worst case space complexity: O(n) total, O(1) auxiliary
     * 
     */

    public class SelectionSort
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;

        #endregion

        //################################################################################
        #region Constructor

        public SelectionSort(int[] array)
        {
            m_Array = array;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        /// <summary>
        /// 
        /// </summary>
        public void Sort()
        {
            int minIndex = 0;

            for (int i = 0; i < m_Array.Length; i++)
            {
                for (int j = i; j < m_Array.Length; j++)
                {
                    if (m_Array[j] < m_Array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i == minIndex)
                {
                    minIndex++;
                    continue;
                }

                var temp = m_Array[i];
                m_Array[i] = m_Array[minIndex];
                m_Array[minIndex] = temp;
            }
        }

        public void TraceSort(Tracer tracer)
        {
            int minIndex = 0;
#if TRACE
            tracer.CurrentArray(m_Array);
            var sortCount = 0;
#endif
            for (int i = 0; i < m_Array.Length; i++)
            {
                for (int j = i; j < m_Array.Length; j++)
                {
                    if (m_Array[j] < m_Array[minIndex])
                    {
                        minIndex = j;
#if TRACE
                        sortCount++;
#endif
                    }
                }

                if (i == minIndex)
                {
                    minIndex++;
                    continue;
                }

                var temp = m_Array[i];
                m_Array[i] = m_Array[minIndex];
                m_Array[minIndex] = temp;
#if TRACE
                tracer.CurrentArray(m_Array);
#endif
            }
#if TRACE
            tracer.WriteOutput($"TOTAL SORT COUNT: {sortCount}");
#endif
        }

        #endregion
    }
}
