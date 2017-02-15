using System;
using System.Collections.Generic;

namespace TestHelpers
{
    public class IntArrayGenerator
    {
        //################################################################################
        #region Fields

        private readonly int[] m_Array;
        private readonly int m_ArraySize;

        #endregion

        //################################################################################
        #region Constructor

        public IntArrayGenerator(int arraySize)
        {
            m_Array = new int[arraySize];
            m_ArraySize = arraySize;
            InitializeArray(arraySize);
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        public int[] GetSorted()
        {
            return m_Array;
        }

        public int[] GetUnsorted()
        {
            return MixArray();
        }

        public int[] GetReversed()
        {
            var arrayTemp = new int[m_ArraySize];
            m_Array.CopyTo(arrayTemp, 0);
            Array.Reverse(arrayTemp);
            return arrayTemp;
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void InitializeArray(int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                m_Array[i] = i + 1;
            }
        }

        private int[] MixArray()
        {
            var arrayToList = new List<int>();
            var arrayTemp = new int[m_ArraySize];
            m_Array.CopyTo(arrayTemp, 0);
            var tempArrayIndex = 0;
            var random = new Random();

            //Copy array to list
            foreach (int t in arrayTemp)
            {
                arrayToList.Add(t);
            }

            while (arrayToList.Count > 0)
            {
                //Generate a random index
                var index = random.Next(0, arrayToList.Count);

                arrayTemp[tempArrayIndex] = arrayToList[index];
                tempArrayIndex++;
                arrayToList.RemoveAt(index);
            }

            return arrayTemp;
        }

        #endregion


    }
}
