using System;
using static System.Console;
using static System.Convert;
namespace Initials
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter your first name");
            string firstName = ReadLine().ToUpper().Trim();
            WriteLine("Please enter your middle name");
            string middleName = ReadLine().ToUpper().Trim();
            WriteLine("Please enter your last name");
            string lastName = ReadLine().ToUpper().Trim();

            WriteLine($"Your initials are {firstName[0]}.{middleName[0]}.{lastName[0]}.");


            for (int i = 0; firstName.Length > i; i++)
            {
                Write(firstName[i]);
            }
            ReadKey();

            

        }
    }
}
