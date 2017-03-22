using System.Collections.Generic;

namespace DependencyInversionPrinciple.GoodExample
{
    internal class LogFileWriter : ILoggerService
    {
        void ILoggerService.WriteLog(List<string> logList)
        {
            //write logs to file
        }
    }
}
