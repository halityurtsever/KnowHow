using CodeHelpers;
using System;

namespace Algorithms.Sorting.QuickSort
{
    // 4 types of implementation

    // - Pick the last element as pivot
    // - Pick the first element as pivot
    // - Pick a random element as pivot
    // - Pick the median as pivot

    public class QuickSort
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;

        #endregion

        //################################################################################
        #region Constructor

        public QuickSort(int[] array)
        {
            m_Array = array;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        public void Sort(Pivot pivot)
        {
            var low = 0;
            var high = m_Array.Length - 1;

            int partitionIndex = Partition(pivot, m_Array, low, high);

            Sort(m_Array, low, partitionIndex - 1);
            Sort(m_Array, partitionIndex, high);
        }

        public void TraceSort(Tracer tracer)
        {
            throw new NotImplementedException();
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private int Partition(Pivot pivot, int[] array, int low, int high)
        {
            int partitionIndex = SelectPivot(pivot, array.Length);

            for (int i = 0; i <= high - 1; i++)
            {

            }

            //arr[] = {10, 80, 30, 90, 40, 50, 70}
            //arr[] = {10, 30, 80, 90, 40, 50, 70}
            //arr[] = {10, 30, 40, 90, 80, 50, 70}

            return partitionIndex;
        }

        private void Sort(int[] array, int left, int right)
        {

        }

        private int SelectPivot(Pivot pivot, int arrayLength)
        {
            switch (pivot)
            {
                case Pivot.First:
                    return 0;

                case Pivot.Last:
                    return arrayLength - 1;

                case Pivot.Median:
                    int median = arrayLength / 2;
                    return median;

                case Pivot.Random:
                    Random rnd = new Random();
                    int random = rnd.Next(0, arrayLength);
                    return random;
            }

            return 0;
        }

        #endregion
    }

    public enum Pivot
    {
        First,
        Last,
        Median,
        Random
    }
}
