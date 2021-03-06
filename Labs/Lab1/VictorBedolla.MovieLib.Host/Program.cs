﻿
// ITSC 1430
// Victor Bedolla
// 2/7/2018
// 7:30 PM
using System;

namespace Nile.host
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                bool isEqual = quit.Equals(20);
                // this displays the menu
                char choice = MenuDisplay();

                //this processes the menu selection
                switch (choice)
                {
                    //menu options
                    case 'L': MoviesList(); break;
                    case 'A': AddMovie(); break;
                    case 'R': RemoveMovie(); break;
                    case 'Q': quit = true; break;
                };
            };
        }

        //movie variables
        static string title;
        static string description;
        static decimal duration;
        static string own;

        private static char MenuDisplay()
        {
            do
            {
                Console.WriteLine("L)ist Movies");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                input = input.Trim();
                input = input.ToUpper();

                if (String.Compare(input, "L") == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "R")
                    return input[0];
                else if (input == "Q")
                    return input[0];

                Console.WriteLine("Please choose a valid option");
            } while (true);
        }

        static void MoviesList()
        {
            if (!String.IsNullOrEmpty(title))
            {
                own = own.Trim();
                own = own.ToUpper();

                Console.WriteLine(title);
                if (!String.IsNullOrEmpty(description))
                    Console.WriteLine(description);
                string msg = $"Run length = {duration} mins";
                    Console.WriteLine(msg);

                //tells user outputs owned or not owned based on input
                if (String.Compare(own, "Y") == 0)
                    own = "Owned";
                else if (own == "N")
                    own = "Not owned";
                
                Console.WriteLine($"Status = {own}");
            }
            else
                Console.WriteLine("There are no movies in your collection.");
        }

        static void AddMovie()
        {
            //get title
            title = ReadString("Enter a title: ", true);
            //get description
            description = ReadString("Enter an optional description: ", false);
            //get duration
            duration = ReadDecimal("Enter an optional duration (in minutes): ", 0, false);//minimum value is declared here
            //get ownership status
            own = ReadString("Do you own this movie? (Y/N) ", true); // originally said "false"

        }

        static void RemoveMovie()
        {
            Console.WriteLine("Are you sure you want to delete the movie (Y/N)?");
            string remove = Console.ReadLine();
            remove = remove.Trim();
            remove = remove.ToUpper();

            if (String.Compare(remove, "Y") == 0)
            {
                //lists movie prior to deletion
                Console.WriteLine(title);
                Console.WriteLine(description);

                Console.WriteLine("The movie has been deleted.");
                own = "";
                title = "";
                description = "";
            }
        }

        private static string ReadString(string message, bool isRequired)
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();
                //if not required or not entry
                if (!isRequired || value != "")
                    return value;
                Console.WriteLine("An entry is required.");
            } while (true);
        }
        private static decimal ReadDecimal(string message, decimal minValue, bool isRequired)
        {
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();
                if (Decimal.TryParse(value, out decimal result))
                {
                    //if not required or not entry
                    if (result >= minValue)
                        return result;
                };
                // then return the result. This skips the optional movie duration
                if (!isRequired || duration != 0)
                    return result; // make sure something is stored in duration in the right format
                Console.WriteLine("You must enter a value >= 0");
                
                //string formatting
                //string msg = String.Format("Value must be greater than {0}", minValue);
                //Console.WriteLine(msg);
            } while (true);
        }
    }
}