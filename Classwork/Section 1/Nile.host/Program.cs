using System; // last changes made 1/31/18

namespace Nile.host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while(!quit)
            {
                //equality
                bool isEqual = quit.Equals(10);

                //displays menu
                char choice = DisplayMenu();

                //process menu selection
                switch (choice)
                {
                    //case 'l': // makes a lowercase l acceptable in place of uppercase L
                    case 'L': ListProducts(); break;

                    //case 'a':
                    case 'A': AddProduct(); break;

                    //case 'q':
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

                //formatting strings
                //Console.WriteLine("Value must be >= {0}", minValue);
                string msg = String.Format("Value must be >= {0}", minValue); // this takes a parameter, replaces specifiers (numbers) with the argument (minValue)
                                                                    // and returns certain values
                Console.WriteLine(msg); // this is called string formatting
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

                input = input.Trim(); // trims down a string, accepts a list of characters like
                                      //\n and \t and will trim them off the front and back
                //input.ToLower();
                input = input.ToUpper(); // strings are always immutable, this makes it so that
                                         // the input can be used with the effects of input.ToUpper();

                //padding
                //input = input.PadLeft(10); useful for padding out tables

                //starts with
                //input.StartsWith(@"\"); // if true starts with return true, if false starts with return false
                //input.EndsWith(@"\"); // none of these actually have to allocate memory and are very efficient

                //substring
                //string newValue = input.Substring(0, 10);

                //if (input == "L")
                if (String.Compare(input, "L") == 0) // when cases are updated the options here must be updated as well
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
            //if (_name != null && _name != String.Empty)
            //if (_name != null && _name.Length != 0)
            //if (_name != null && _name != "")
            if (!String.IsNullOrEmpty(_name))
            {
                //display a product - name [$price]
                //                    <description>
                //string formatting
                //var msg = String.Format("{0} [${1}]", _name, _price);

                //string concatenation
                //var msg = _name + " [$" + _price + "]";

                //string concat part 2
                //var msg = String.Concat(_name, " [$", _price, "]");

                //string interpolation
                string msg = $"{_name} [${_price}]"; // to use string interpolation you must make it clear
                                          // that you are using it, put a $ before the quotes
                                        // and you can use nearly anything you like for it
                Console.WriteLine(msg); // msg is now replacing name and price
                //Console.WriteLine(_name);
                //Console.WriteLine(_price);

                if (!String.IsNullOrEmpty(_description))
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
