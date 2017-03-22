using System.Collections.Generic;

namespace DependencyInversionPrinciple.GoodExample
{
    internal class LogConsoleWriter : ILoggerService
    {
        void ILoggerService.WriteLog(List<string> logList)
        {
            //write logs to console
        }
    }
}
