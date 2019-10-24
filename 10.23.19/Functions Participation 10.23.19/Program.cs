using System;

namespace Functions_Participation_10._23._19
{
    class Program
    {
        static void Main(string[] args)
        {

            var message = "Enter a number.";
            double input = GetDoubleInputFromUser(message);
            double answer = input * 5;
            Console.WriteLine($"{input} * 5 = {answer}");
            Console.ReadKey();
        }

        static double GetDoubleInputFromUser(string message)
        {

            Console.WriteLine(message);
            string num = Console.ReadLine();
            double numDouble;

            while(double.TryParse(num, out numDouble)==false)
            {
                Console.WriteLine("Invalid number, please try again");
                num = Console.ReadLine();
            }
            return numDouble;
        }
        


        
        

        


    }
}
