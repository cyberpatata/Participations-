using System;
using static System.Console;
using static System.Convert;
namespace Partcipations //Steven Rainey
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input the student's first exam grade.");
            double exam1 = ToDouble(ReadLine());
            WriteLine("Input the student's second exam grade.");
            double exam2 = ToDouble(ReadLine());
            WriteLine("Input the student's third exam grade.");
            double exam3 = ToDouble(ReadLine());

            WriteLine($"The sum of the student's grades is{exam1 + exam2 + exam3}");

            ReadKey();
            



        }
    }
}
