using System.Collections.Generic;

namespace DependencyInversionPrinciple.GoodExample
{
    internal class LogDatabaseWriter : ILoggerService
    {
        void ILoggerService.WriteLog(List<string> logList)
        {
            //write logs to database
        }
    }
}
