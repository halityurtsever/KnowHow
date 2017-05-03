using CodeHelpers;

namespace Algorithms.Sorting.InsertionSort
{
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
