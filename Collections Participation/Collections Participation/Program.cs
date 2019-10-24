using System;
using System.Collections.Generic;
namespace Collections_Participation
{
    class Program
    {//Steven Rainey
        static void Main(string[] args)
        {
            string[] subject = new string[3];
            int[] crn = new int[3];
            
            for(int i = 0; i < crn.Length; i++)
            {
                Console.WriteLine($"Please enter the subject {i + 1} >>");
                string subjectString = Console.ReadLine();
                subject[i] = subjectString;

                Console.WriteLine($"Please enter the course number {i + 1} >>");
                crn[i] = Convert.ToInt32(Console.ReadLine());              

            }

            int index = 0;

            while(index < crn.Length)
            {
                Console.WriteLine($"{subject[index]}{crn[index]}");
                index++;              
            }

            List<double> grade = new List<double>();
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

                grade.Add(gradeDouble);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() != "no");

            Console.ReadKey();
        }
    }
}
