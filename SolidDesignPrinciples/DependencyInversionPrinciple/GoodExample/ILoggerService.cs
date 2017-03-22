using System.Collections.Generic;

namespace DependencyInversionPrinciple.GoodExample
{
    internal interface ILoggerService
    {
        void WriteLog(List<string> logList);
    }
}
