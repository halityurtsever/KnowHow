using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Adapter
{
    internal class Adapter : IAdapter
    {
        private readonly Adaptee m_Adaptee;

        public Adapter(Adaptee adaptee)
        {
            m_Adaptee = adaptee;
        }

        public List<string> GetNameList()
        {
            var nameArray = m_Adaptee.GetNames();

            return nameArray.ToList();
        }
    }
}
