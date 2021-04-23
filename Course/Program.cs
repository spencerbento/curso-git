using System;
using System.Globalization;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan d1 = new TimeSpan(1, 30, 10);
            TimeSpan d2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = d1 - d2;
            TimeSpan mult = d2 * 2;

            Console.WriteLine(sum);
            Console.WriteLine(mult);


            Console.WriteLine("Bom dia!");
            


        }

        
    }
}