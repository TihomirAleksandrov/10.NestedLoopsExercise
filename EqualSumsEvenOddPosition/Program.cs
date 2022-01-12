using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                string num = Convert.ToString(i);

                char even1 = num[1];
                char even2 = num[3];
                char even3 = num[5];

                char odd1 = num[0];
                char odd2 = num[2];
                char odd3 = num[4];

                int evenSum = even1 + even2 + even3;
                int oddSum = odd1 + odd2 + odd3;

                while (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                    break;
                }
            }
        }
    }
}
