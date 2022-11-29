using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELCIUS_TO_FAHRENHEIT_CONVERTER
{
    class Program
    {
        static double celcius_to_fahrenheit (double temp)
        {
            /* fahrenheit = (celcius * 9) / 5 + 32 */
            double fahrenheit, celcius;
            Console.WriteLine("Enter a temperature in celcius unit: ");
            celcius = temp;
            if (celcius < -271.51)
            {
                Console.WriteLine("You can't enter a value below -271.51.");
                return 0;
            }

            Console.WriteLine("Celcius: " + celcius);
            fahrenheit = celcius * 9 / 5 + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            double answer = celcius_to_fahrenheit(20);
            Console.WriteLine("The value in fahrenheits units is: " + answer);
            Console.ReadKey();
        }
    }
}
