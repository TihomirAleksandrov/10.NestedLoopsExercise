using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCounter = 0;
            int standartCounter = 0;
            int kidCounter = 0;
            double totalCounter = 0;
            double movieTicketsSold = 0;
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());
                string movieName = input;
                movieTicketsSold = 0;
                input = Console.ReadLine();

                for (int i = freeSeats; i > 0; i--)
                {
                    if (input == "student")
                    {
                        studentCounter++;
                    }
                    else if (input == "standard")
                    {
                        standartCounter++;
                    }
                    else if (input == "kid")
                    {
                        kidCounter++;
                    }

                    if (input == "End")
                    {
                        break;
                    }

                    movieTicketsSold++;
                    totalCounter++;

                    if (freeSeats == movieTicketsSold)
                    {
                        break;
                    }
                    input = Console.ReadLine();
                }

                double ticketsSoldPercent = (movieTicketsSold / freeSeats) * 100;
                Console.WriteLine($"{movieName} - {ticketsSoldPercent:f2}% full.");
            }

            double studentTicketPercent = (studentCounter / totalCounter) * 100;
            double standartTicketPercent = (standartCounter / totalCounter) * 100;
            double kidTicketPercent = (kidCounter / totalCounter) * 100;

            Console.WriteLine($"Total tickets: {totalCounter}");
            Console.WriteLine($"{studentTicketPercent:f2}% student tickets.");
            Console.WriteLine($"{standartTicketPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercent:f2}% kids tickets.");
        }
    }
}
