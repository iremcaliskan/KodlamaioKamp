using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Part2
{
    class LoggerManager
    {
        public void Apply(ILoggerService loggerService)
        {
            loggerService.Log();
        }
    }
}
