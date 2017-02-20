using CodeHelpers;

namespace Algorithms.Sorting.SelectionSort
{
    /** Selection sort algorithm
     * Swaps [i] and [i + 1] if [i] smaller then [i + 1] until m_Array ordered
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Pass 1             -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     *                       ^   ^
     *                       swap 7 and 3
     * 
     * Pass 2             -> 3 - 7 - 5 - 9 - 2 - 8 - 6 - 1 - 4
     *                               ^   ^
     *                               swap 9 and 5
     * 
     * Pass 3             -> 3 - 7 - 5 - 2 - 9 - 8 - 6 - 1 - 4
     *                                   ^   ^
     *                                   swap 9 and 2
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
