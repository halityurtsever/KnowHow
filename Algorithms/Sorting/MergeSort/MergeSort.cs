using CodeHelpers;
using System;

namespace Algorithms.Sorting.MergeSort
{
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
            if (left == right)
            {
                return;
            }

            var difference = right - left;
            var middle = (right + left) / 2;

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
