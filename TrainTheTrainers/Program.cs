using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double averageScore = 0;
            double totalScore = 0;
            double totalGrade = 0;
            double averageGrade = 0;
            int counter = 0;

            while (input != "Finish")
            {
                totalScore = 0;
                counter++;

                for (int i = 1; i <= juryNum; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalScore += grade;
                }

                averageScore = totalScore / juryNum;
                totalGrade += averageScore;

                Console.WriteLine($"{input} - {averageScore:f2}.");
                input = Console.ReadLine();
            }

            averageGrade = totalGrade / counter;

            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        }
    }
}
