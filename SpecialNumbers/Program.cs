using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                string number = Convert.ToString(i);
                counter = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int digit = Convert.ToInt32(number[j].ToString());

                    if (digit == 0)
                    {
                        continue;
                    }
                    else if (num % digit == 0)
                    {
                        counter++;

                        if (counter == 4)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
