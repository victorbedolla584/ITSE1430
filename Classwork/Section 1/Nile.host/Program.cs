using System;

namespace Nile.host
{
    class Program
    {
        static void Main( string[] args )
        {
        }

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
