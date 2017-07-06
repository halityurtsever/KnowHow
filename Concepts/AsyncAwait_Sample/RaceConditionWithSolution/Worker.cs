using System.Collections.Generic;
using System.IO;

namespace Concepts.AsyncAwait_Sample.RaceConditionWithSolution
{
    internal class Worker
    {
        //################################################################################
        #region Fields

        private const string FilePath = @"C:\tmp\race_condition.txt";

        #endregion

        //################################################################################
        #region Internal Implementation

        internal bool WriteIntoFile(List<string> printList)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText(FilePath))
                {
                    foreach (var item in printList)
                    {
                        streamWriter.WriteLine(item);
                    }
                }

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
