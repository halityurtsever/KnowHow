
using CodeHelpers;

namespace BubbleSort
{
    /** Bubble sort algorithm
     * Swaps [i] and [i + 1] if [i] smaller then [i + 1] until m_Array ordered
     * 
     * Initial m_Array    -> 7 - 3 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     * 
     * Pass 1           -> 3 - 7 - 9 - 5 - 2 - 8 - 6 - 1 - 4
     *                     ^   ^
     *                     swap 7 and 3
     * 
     * Pass 2           -> 3 - 7 - 5 - 9 - 2 - 8 - 6 - 1 - 4
     *                             ^   ^
     *                             swap 9 and 5
     * 
     * Pass 3           -> 3 - 7 - 5 - 2 - 9 - 8 - 6 - 1 - 4
     *                                 ^   ^
     *                                 swap 9 and 2
     * and goes on...
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

        public void TraceSort()
        {
            bool isSwapped = true;
#if TRACE
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
                        //Current m_Array
                        var arrayOutput = string.Empty;
                        for (int j = 0; j < m_Array.Length; j++)
                        {
                            arrayOutput += $"{m_Array[j]}-";
                        }
                        Tracer.ToFile($"CURRENT ARRAY: {arrayOutput.Substring(0, arrayOutput.Length - 1)}");
                        swapCount++;
#endif
                    }
                }
            }
#if TRACE
            Tracer.ToOutput($"TOTAL SWAP COUNT: {swapCount}");
#endif
        }

        #endregion
    }
}
