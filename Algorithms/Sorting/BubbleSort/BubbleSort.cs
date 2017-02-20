
using CodeHelpers;

namespace Algorithms.Sorting.BubbleSort
{
    /** Bubble sort algorithm
     * Swaps [i] and [i + 1] if [i] smaller then [i + 1] until m_Array ordered
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Pass 1           -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     *                     ^---^
     *                     swap 7 and 3
     * 
     * Pass 2           -> 3 - 7 - 5 - 9 - 2 - 8 - 6 - 1 - 4
     *                             ^---^
     *                             swap 9 and 5
     * 
     * Pass 3           -> 3 - 7 - 5 - 2 - 9 - 8 - 6 - 1 - 4
     *                                 ^---^
     *                                 swap 9 and 2
     * and goes on...
     * 
     * Worst case performance: O(n2)
     * Best case performance: O(n)
     * Average performance: O(n2)
     * Worst case space complexity: O(1) auxiliary
     * 
     */

    public class BubbleSort
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;

        #endregion

        //################################################################################
        #region Constructor

        public BubbleSort(int[] array)
        {
            m_Array = array;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        /// <summary>
        /// Method takes an m_Array as a parameter and sort it by using Bubble Sort algorithm.
        /// Because of int[] is a reference type object, no need to return it.
        /// </summary>
        public void Sort()
        {
            bool isSwapped = true;
            while (isSwapped)
            {
                isSwapped = false;

                for (int i = 0; i < m_Array.Length - 1; i++)
                {
                    if (m_Array[i] > m_Array[i + 1])
                    {
                        var temp = m_Array[i + 1];
                        m_Array[i + 1] = m_Array[i];
                        m_Array[i] = temp;
                        isSwapped = true;
                    }
                }
            }
        }

        public void TraceSort(Tracer tracer)
        {
            bool isSwapped = true;
#if TRACE
            tracer.CurrentArray(m_Array);
            var swapCount = 0;
#endif
            while (isSwapped)
            {
                isSwapped = false;

                for (int i = 0; i < m_Array.Length - 1; i++)
                {
                    if (m_Array[i] > m_Array[i + 1])
                    {
                        var temp = m_Array[i + 1];
                        m_Array[i + 1] = m_Array[i];
                        m_Array[i] = temp;
                        isSwapped = true;
#if TRACE
                        tracer.CurrentArray(m_Array);
                        swapCount++;
#endif
                    }
                }
            }
#if TRACE
            tracer.WriteOutput($"TOTAL SWAP COUNT: {swapCount}");
#endif
        }

        #endregion
    }
}
