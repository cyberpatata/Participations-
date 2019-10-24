using System;

namespace _10._23._19
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <+ 100; i++)
            {
                FizzBuzz(i);
            }
            Console.ReadKey();           
                           
        }

        static void FizzBuzz(int userNumber)
        {
            
            if (userNumber % 5 == 0 & userNumber % 3 == 0)
            {
                Console.WriteLine($"{userNumber} is FizzBuzz");
                
            }
            else if (userNumber % 3 == 0)
            {
                Console.WriteLine($"{userNumber} is Fizz");
                
            }
            else if (userNumber % 5 == 0)
            {
                Console.WriteLine($"{userNumber} is Buzz");
            }
            else
            {
                Console.WriteLine($"{userNumber} is Not Lucky");
            }
            
        }
        
    }
}
