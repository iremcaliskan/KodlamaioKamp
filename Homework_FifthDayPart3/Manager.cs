﻿using System;

namespace Homework_FifthDayPart3
{
    class Manager : IWorker, IEat, IGetSalary
    { // Bir class birden fazla interface'i implement edebilir.
        public void Eat()
        {
            Console.WriteLine("Lunch time for Managers.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Work time for Managers.");
        }
    }


}
