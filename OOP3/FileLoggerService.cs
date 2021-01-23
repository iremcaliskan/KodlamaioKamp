using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    { // ILoggerService alternatifi
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
