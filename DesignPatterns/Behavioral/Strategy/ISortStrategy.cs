using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// "Strategy" interface
    /// </summary>
    public interface ISortStrategy
    {
        void Sort(int[] unsortedList);
    }
}
