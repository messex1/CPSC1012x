using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Purpose:  For calculating windchill, based on user input of temperature
//Input: 32, 0, -10
//Output: 
//Written by: Michael Essex
//Written for: Carlos Estay-Oyarzo
//Section: OE01
//Last Modified Date: 9/24/2022

namespace Chilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int tempa;
            int tempb;
            int tempc;

            const int velocitya = 10;
            const int velocityb = 25;
            const int velocityc = 40;


            double windchill1 = 0;
            double windchill2 = 0;
            double windchill3 = 0;

            Console.WriteLine("what is the temperature? 32, 0 or -10?:   ");
            input = Console.ReadLine();
            tempa = int.Parse(input);
            tempb = int.Parse(input);
            tempc = int.Parse(input);

            //Test Case 1
            windchill1 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocitya, 0.16) + 0.4275 * tempa * Math.Pow(velocitya, 0.16);
            windchill2 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocityb, 0.16) + 0.4275 * tempa * Math.Pow(velocityb, 0.16);
            windchill3 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocityc, 0.16) + 0.4275 * tempa * Math.Pow(velocityc, 0.16);

            while (tempa == 32)
            {
                Console.WriteLine("The Windchill for " + tempa + " with a wind velocity of " + velocitya + " would be" + windchill1 + " cold ");

                Console.WriteLine("The Windchill for " + tempa + " with a wind velocity of " + velocityb + " would be" + windchill2 + " cold ");

                Console.WriteLine("The Windchill for " + tempa + " with a wind velocity of " + velocityc + " would be" + windchill3 + " cold ");
                tempa = Convert.ToInt16(Console.ReadLine());

            }





            Test Case 2

            windchill1 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocitya, 0.16) + 0.4275 * tempa * Math.Pow(velocitya, 0.16);
            windchill2 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocityb, 0.16) + 0.4275 * tempa * Math.Pow(velocityb, 0.16);
            windchill3 = 35.74 + 0.6215 * tempa - 35.75 * Math.Pow(velocityc, 0.16) + 0.4275 * tempa * Math.Pow(velocityc, 0.16);

            while (tempb == 0)
            {
                Console.WriteLine("The Windchill for " + tempb + " with a wind velocity of " + velocitya + " would be" + windchill1 + " cold ");

                Console.WriteLine("The Windchill for " + tempb + " with a wind velocity of " + velocityb + " would be" + windchill2 + " cold ");

                Console.WriteLine("The Windchill for " + tempb + " with a wind velocity of " + velocityc + " would be" + windchill3 + " cold ");
                tempb = Convert.ToInt16(Console.ReadLine());

            }

            Test Case 3

            windchill1 = 35.74 + 0.6215 * tempc - 35.75 * Math.Pow(velocitya, 0.16) + 0.4275 * tempc * Math.Pow(velocitya, 0.16);
            windchill2 = 35.74 + 0.6215 * tempc - 35.75 * Math.Pow(velocityb, 0.16) + 0.4275 * tempc * Math.Pow(velocityb, 0.16);
            windchill3 = 35.74 + 0.6215 * tempc - 35.75 * Math.Pow(velocityc, 0.16) + 0.4275 * tempc * Math.Pow(velocityc, 0.16);

            while (tempc == -10)
            {
                Console.WriteLine("The Windchill for " + tempc + " with a wind velocity of " + velocitya + " would be" + windchill1 + " cold ");

                Console.WriteLine("The Windchill for " + tempc + " with a wind velocity of " + velocityb + " would be" + windchill2 + " cold ");

                Console.WriteLine("The Windchill for " + tempc + " with a wind velocity of " + velocityc + " would be" + windchill3 + " cold ");
                tempc = Convert.ToInt16(Console.ReadLine());

            }



        }
    }
}
