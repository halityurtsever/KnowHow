using System.Collections.Generic;

namespace DependencyInversionPrinciple.GoodExample
{
    internal class SonarAnalyzer
    {
        private List<string> m_LogList = new List<string>();
        private ILoggerService m_LoggerService;

        public SonarAnalyzer(ILoggerService loggerService)
        {
            m_LoggerService = loggerService;
        }

        internal void AnalyzeProject()
        {
            //start analyze

            //add logs to list when occur
            m_LogList.Add("new log");

            //finish analyze

            //write log list independently what logger service is it.
            //high level module not depend on low level module, it's only depend on abstraction layer
            m_LoggerService.WriteLog(m_LogList);
        }
    }
}
