using System;

namespace OOP3_Part2
{
    class FileLoggerService : ILoggerService
    { // ILoggerService alternatifi
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
