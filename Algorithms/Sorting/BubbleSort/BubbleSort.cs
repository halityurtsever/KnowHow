using CodeHelpers;

namespace Algorithms.Sorting.BubbleSort
{
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
