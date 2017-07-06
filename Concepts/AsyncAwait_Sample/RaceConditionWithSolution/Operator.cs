using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.AsyncAwait_Sample.RaceConditionWithSolution
{
    internal class Operator
    {
        //################################################################################
        #region Fields

        private readonly string m_Prefix;
        private readonly int m_ListLength;
        private readonly Worker m_Worker = new Worker();
        private readonly List<string> m_PrintList = new List<string>();

        #endregion

        //################################################################################
        #region Constructor

        public Operator(string prefix, int length)
        {
            m_Prefix = prefix;
            m_ListLength = length;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal async Task<bool> PrintListToFile()
        {
            return await ExecutePrint();
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private Task<bool> ExecutePrint()
        {
            CreateList();
            return Task<bool>.Factory.StartNew(() => m_Worker.WriteIntoFile(m_PrintList));
        }

        private void CreateList()
        {
            for (int i = 0; i < m_ListLength; i++)
            {
                m_PrintList.Add($"{m_Prefix}_{GetHashedValue()}");
            }
        }

        private string GetHashedValue()
        {
            var stringBuilder = new StringBuilder();

            using (SHA512 sha512 = new SHA512Managed())
            {
                var data = Guid.NewGuid().ToString();
                var hash = sha512.ComputeHash(Encoding.Unicode.GetBytes(data));

                foreach (var byteValue in hash)
                {
                    stringBuilder.AppendFormat("{0:X}", byteValue);
                }
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
