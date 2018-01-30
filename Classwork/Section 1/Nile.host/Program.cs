using System;

namespace Nile.host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while(!quit)
            {
                //displays menu
                char choice = DisplayMenu();

                //process menu selection
                switch (choice)
                {
                    case 'l': // makes a lowercase l acceptable in place of uppercase L
                    case 'L': ListProducts(); break;

                    case 'a':
                    case 'A': AddProduct(); break;

                    case 'q':
                    case 'Q': quit = true; break;
                };
            };
        }

        static void AddProduct()
        {
            //get name
            _name = ReadString("Enter name: ", true);

            //get price
            _price = ReadDecimal("Enter price: ", 0);

            //get description
            _description = ReadString("Enter optional description: ", false);
        }

        private static decimal ReadDecimal( string message, decimal minValue )
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

                Console.WriteLine("Value must be >= {0}", minValue); // this is called string formatting
            } while (true);
        }

        private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                //if not required or not entry
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required");
            } while (true);
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("(L)ist Products");
                Console.WriteLine("(A)dd Product");
                Console.WriteLine("(Q)uit");

                string input = Console.ReadLine();

                if (input == "L" || input == "l") // when cases are updated the options here must be updated as well
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "Q")
                    return input[0];

                Console.WriteLine("Please choose a valid option");
            } while (true);
        }

        static void ListProducts()
        {
            //are there any products?
            if (_name != null && _name != "")
            {

                //display a product
                Console.WriteLine(_name);
                Console.WriteLine(_price);
                Console.WriteLine(_description);
            } else
                Console.WriteLine("No products");
        }

        //data for a product
        static string _name;
        static decimal _price;
        static string _description;

        static void PlayingWithPrimitives()
        {
            //primitive
            decimal unitPrice = 10.5M;

            //real declaration
            //System.Decimal unitPrice2 = 10.5M;
            Decimal unitPrice2 = 10.5M;

            //current time
            System.DateTime now = DateTime.Now;

            System.Collections.ArrayList items;
        }
        static void PlayingWithVariables ()
        {
            //single declarations
            int hours = 0;
            double rate = 10.25; // both int and double are blue, meaning they are key words

            if (false)
                hours = 0;

            int hours2 = hours;

            //multiple declarations
            string firstName, lastName;

            //string @class;

            //single assignment
            firstName = "Bob";
            lastName = "Miller";

            //multiple assignments
            firstName = lastName = "Sue";

            //math operations
            int x = 0, y = 10;
            int add = x + y;
            int subtract = x - y;
            int multiply = x * y;
            int divide = x / y;
            int modulos = x % y;

            //x = x + 10;
            x += 10;
            double ceiling = Math.Ceiling(rate);
            double floor = ceiling;
        }
    }
}
