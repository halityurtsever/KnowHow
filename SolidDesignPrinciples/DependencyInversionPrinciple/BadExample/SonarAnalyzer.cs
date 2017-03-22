using System.Collections.Generic;

namespace SolidDesignPrinciples.DependencyInversionPrinciple.BadExample
{
    internal class SonarAnalyzer
    {
        private List<string> m_LogList = new List<string>();

        internal void AnalyzeProject()
        {
            //start analyze

            //add logs to list when occur
            m_LogList.Add("new log");

            //finish analyze

            //write log list (when new log writer is implemented code need to change)
            //high level and low level are very dependent to each other
            WriteLogsToConsole();
            WriteLogsToFile();
            WriteLogsToDatabase();
        }

        private void WriteLogsToConsole()
        {
            //write logs to console here
        }

        private void WriteLogsToFile()
        {
            //write logs to file here
        }

        private void WriteLogsToDatabase()
        {
            //write logs to database here
        }
    }
}
