using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_JavaToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to enter a series of integers and display 'Largest' and 'Smallest'
            string input;
            bool result = false;
            int smallest = 0;
            int biggest = 0;
            int count = 0;

            // Loop the program to get multiple numbers
            while (!result)
            {
                // Write to user and get the users input.
                Console.WriteLine("Enter a list of numbers, one number at a time.");
                input = Console.ReadLine();

                // If user enters '-99' end the program and show results.
                if (!input.Equals("-99"))
                {
                    // Check to make sure the user input is a number.
                    if (Int32.TryParse(input, out int hold))
                    {
                        // On very first pass set biggest and smallest defaults to input.
                        if (count == 0)
                        {
                            smallest = hold;
                            biggest = hold;
                            count++;
                        }

                        if (hold < smallest)
                        {
                            smallest = hold;    // Get the smallest value.
                        }
                        else if (hold > biggest)    // Get the biggest value.
                        {
                            biggest = hold;
                        }
                    }
                    else
                    {
                        Console.WriteLine("User input must be a whole number(Integer), Error input not number" +
                                                 "\nPress any key to exit the program and continue.");
                        result = true;
                        Console.ReadKey();
                    }
                }
                else
                {
                    //Show biggest and smallest numbers.
                    Console.WriteLine("\nHere are the biggest and smallest numbers from the user input");
                    Console.WriteLine("Biggest: " + biggest);
                    Console.WriteLine("Smallest: " + smallest);
                    Console.WriteLine();
                    Console.WriteLine("\nPress any key to exit the program and continue.");
                    Console.ReadKey();
                    result = true;
                }
            }         
        }
    }
}
