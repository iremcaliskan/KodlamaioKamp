﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    { // ILoggerService alternatifi
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
