﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Try to parse the input as an integer
            if (int.TryParse(input, out int age))
            {
                //  Ticket price based on the age
                int ticketPrice;
                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7;
                }
                else
                {
                    ticketPrice = 10;
                }

                // Display the ticket price
                Console.WriteLine("Your ticket price is: GHC" + ticketPrice);
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid age entered. Please enter a valid number.");
            }
        }
    }
}
