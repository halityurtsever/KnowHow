using System;
using CodeHelpers;

namespace Algorithms.Sorting.MergeSort
{
    /**
     * 
     * 
     * 
     * 
     */

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
            var startIndex = 0;
            var endIndex = m_Array.Length - 1;

            Sort(m_Array, startIndex, endIndex);
        }

        public void TraceSort(Tracer tracer)
        {
            throw new NotImplementedException();
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void Sort(int[] array, int startIndex, int endIndex)
        {
            var difference = endIndex - startIndex;
            var middleIndex = (endIndex + startIndex)/2;

            if (startIndex == endIndex)
            {
                return;
            }

            if (difference >= 1)
            {
                //sort left part
                Sort(array, startIndex, middleIndex);

                //sort right part
                Sort(array, middleIndex + 1, endIndex);
            }

            Merge(array, startIndex, middleIndex, endIndex);
        }

        private void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            //create temp array
            int[] tempArray = new int[endIndex - startIndex + 1];

            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;
            int tempIndex = 0;

            while (tempIndex < tempArray.Length)
            {
                if (leftIndex > startIndex || rightIndex > middleIndex + 1)
                {
                    break;
                }

                if (array[leftIndex] > array[rightIndex])
                {
                    tempArray[tempIndex] = array[rightIndex];
                    rightIndex++;
                }
                else
                {
                    tempArray[tempIndex] = array[leftIndex];
                    leftIndex++;
                }

                tempIndex++;
            }

            //if any index left from left side
            if (leftIndex <= startIndex)
            {
                for (int i = leftIndex; i <= startIndex; i++)
                {
                    tempArray[tempIndex] = array[leftIndex];
                    tempIndex++;
                }
            }

            //if any index left from right side
            if (rightIndex <= middleIndex + 1)
            {
                for (int i = rightIndex; i <= middleIndex + 1; i++)
                {
                    tempArray[tempIndex] = array[rightIndex];
                    tempIndex++;
                }
            }

            //copy temp array to real array
            Array.Copy(tempArray, 0, array, startIndex, tempArray.Length);
        }

        #endregion
    }
}
