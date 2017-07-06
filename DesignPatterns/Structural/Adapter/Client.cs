using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter
{
    internal class Client
    {
        private readonly IAdapter m_Adapter;

        public Client(IAdapter adapter)
        {
            m_Adapter = adapter;
        }

        internal List<string> GetNameList()
        {
            return m_Adapter.GetNameList();
        }
    }
}
