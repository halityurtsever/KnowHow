using CodeHelpers;

namespace Algorithms.Sorting.SelectionSort
{


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
