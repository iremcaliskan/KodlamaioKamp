using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService
    { //Interface'lere Service denir.
        // Interface olduğu için sadece imza koyulur!
        // Sadece imza metodları olur, içi dolu olamaz.

        void Log(); //Loglama yapmak
    }
}
