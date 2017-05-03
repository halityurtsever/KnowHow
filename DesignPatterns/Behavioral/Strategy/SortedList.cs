using System;

namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// "Context" class
    /// </summary>
    internal class SortedList
    {
        //################################################################################
        #region Fields

        private int[] m_List;
        private ISortStrategy m_SortStrategy;

        #endregion

        //################################################################################
        #region Properties

        public ISortStrategy SortStrategy
        {
            get
            {
                return m_SortStrategy;
            }

            set
            {
                m_SortStrategy = value;
            }
        }

        public int[] List
        {
            get
            {
                return m_List;
            }

            set
            {
                m_List = value;
            }
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void Sort()
        {
            //sort list
            m_SortStrategy.Sort(m_List);

            //print list
            Console.WriteLine(m_SortStrategy.ToString());
            foreach (int t in m_List)
            {
                Console.WriteLine(t);
            }
        }

        #endregion
    }
}
