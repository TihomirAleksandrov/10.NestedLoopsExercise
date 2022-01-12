using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            bool isNonPrime = false;

            while (true)
            {
                if (input == "stop")
                {
                    break;
                }

                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i <= 5; i++)
                {
                    if (num == 0 || num == 2 || num == 3 || num == 5)
                    {
                        break;
                    }
                    else if (num % i == 0)
                    {
                        isNonPrime = true;
                        break;
                    }
                }

                if (isNonPrime)
                {
                    nonPrimeSum += num;
                }
                else
                {
                    primeSum += num;
                }

                isNonPrime = false;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
