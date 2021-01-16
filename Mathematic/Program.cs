using System;

namespace Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations calculations = new Calculations();
            calculations.Add(5, 6);
            calculations.Subtraction(5, 6);
            calculations.Multiplication(5, 6);
            calculations.Division(5, 6);
        }
    }
}
