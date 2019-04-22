using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_temperature_conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            int temperature = 0;
            string end;
          

            do
            {

                Console.WriteLine("Please enter a temperature");
                string reply = Console.ReadLine();
                bool isNumerical = int.TryParse(reply, out temperature);

                Console.WriteLine("Enter 'C' to convert this to Celsius or enter 'F' to convert this to Fahrenheit?");
                string tempType = Console.ReadLine();

                        if (tempType == "c")
                        {
                            temperature = (temperature - 32) * 5 / 9;
                            Console.WriteLine("The temperature in Celsius  is: " + temperature);
                        }

                        else if (tempType == "f")
                        {
                            temperature = (temperature * 9 / 5) + 32;
                            Console.WriteLine("The temperature in Fahrenheit is: " + temperature);
                        }

                Console.WriteLine("Do you want to check another temperature?");
                end = Console.ReadLine();

                if (end == "n")
                { break;
                }
            } while (true) ; 
            
        }

    }
}  ///temperature = answer !="Exit"
