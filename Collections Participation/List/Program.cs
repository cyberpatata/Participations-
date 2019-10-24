using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Please enter your grade. >>");
                string gradeAsAString = Console.ReadLine();//this variable is only used if user enters a non number
                double gradeDouble;
                while (double.TryParse(gradeAsAString, out gradeDouble) == false)  //use this only to check if the input is a number. used only in user inputs a letter instead of a number for the grade
                {
                    Console.WriteLine("Invalid entry, please try again.");
                    Console.WriteLine("Please enter your grade.");
                    gradeAsAString = Console.ReadLine();
                }

                grades.Add(gradeDouble);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() != "no");

            double sum = 0;

            foreach(var grade in grades)
            {
                sum += grade;
            }


            Console.ReadKey();
        }
    }
}
