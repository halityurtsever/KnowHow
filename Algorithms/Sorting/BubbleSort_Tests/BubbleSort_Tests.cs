using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelpers;

namespace BubbleSort.Tests
{
    [TestClass()]
    public class BubbleSort_Tests
    {
        //################################################################################
        #region Fields

        private IntArrayGenerator m_ArrayGenerator;

        #endregion

        //################################################################################
        #region Tests

        [TestMethod()]
        public void Sort_UnsortedArray_Test()
        {
            //Assign
            m_ArrayGenerator = new IntArrayGenerator(100);
            var sortedArray = m_ArrayGenerator.GetSorted();
            var unsortedArray = m_ArrayGenerator.GetUnsorted();

            //Act
            var bubbleSort = new BubbleSort(unsortedArray);
            bubbleSort.Sort();

            //Assert
            Assert.AreEqual(sortedArray[0], unsortedArray[0]);
            Assert.AreEqual(sortedArray[10], unsortedArray[10]);
            Assert.AreEqual(sortedArray[40], unsortedArray[40]);
            Assert.AreEqual(sortedArray[90], unsortedArray[90]);
        }

        [TestMethod()]
        public void Sort_ReversedArray_Test()
        {
            //Assign
            m_ArrayGenerator = new IntArrayGenerator(100);
            var sortedArray = m_ArrayGenerator.GetSorted();
            var reversedArray = m_ArrayGenerator.GetReversed();

            //Act
            var bubbleSort = new BubbleSort(reversedArray);
            bubbleSort.Sort();

            //Assert
            Assert.AreEqual(sortedArray[0], reversedArray[0]);
            Assert.AreEqual(sortedArray[10], reversedArray[10]);
            Assert.AreEqual(sortedArray[40], reversedArray[40]);
            Assert.AreEqual(sortedArray[90], reversedArray[90]);
        }

        #endregion
    }
}