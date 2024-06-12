//Purpose: Lab 2 
//Input: Choice of equation, and values of said equation
//Output: anwser to chosen equation
//Written by: Michael Essex
//Written for: Carlos Estay-Oyarzo
//Section: OE01
//Last Modified Date: 10/8/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_MichaelEssex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double cos, sin, tan, adj, opp, hyp;
            int option;

            double PI;
            double theta;
            //theta = the angle
            double degrees;
            double angle = ((Math.PI * degrees) % 2);





            Console.WriteLine("Chose your formula: 1, 2, or 3");
            Console.WriteLine(" 1 =  adjacent & opposite");
            Console.WriteLine(" 2 = adjacent & hypotenuse");//2 
            Console.WriteLine(" 3 = opposite & hypotenuse");//2
            Console.WriteLine("Please enter the number associated with the forumala");
            input = Console.ReadLine();
            option = int.Parse(Console.ReadLine());


            //choice 4 = invalid

            //Menu Choice 1
            //TEST CASE 1
            if (option == '1')
            {
                Console.WriteLine("what is the value of adjacent?: ");
                input = Console.ReadLine();
                adj = int.Parse(Console.ReadLine());
                //determines value of adj

                Console.WriteLine("what is the value of opposite?: ");
                input = Console.ReadLine();
                opp = int.Parse(Console.ReadLine());
                //determines value of opposite

                //formula             
                theta = Console.WriteLine("Adjacent = {0}, Angle = {0}", theta);

            }
        }

        /*

        //Menu Choice 2 - 2 input versions
        if (option == '2')
        {
            Console.WriteLine("what is the value of adjacent?: ");
                input = Console.ReadLine();
            adj = int.Parse(Console.ReadLine());
            //determines value of adj

            Console.WriteLine("what is the value of hypotenuse?: ");
                input = Console.ReadLine();
            hyp = int.Parse(Console.ReadLine());
            //determines value of opposite

            degrees = Math.Acos(adj, hyp);
            Console.WriteLine("opposite = {0}, Angle = {0}", degrees);
            //formula


            //TEST CASE 2       
            //input version 1//
                if (adj == 5 && hyp == 6)
            {

                degrees = Math.Acos(adj, hyp);
                Console.WriteLine("The angle of this equation is: {0}", degrees);
                }
            //TEST CASE 3
            //input version 2
            if (adj == 6 && hyp == 5)
            {

                degrees = Math.Acos(adj, hyp);
                Console.WriteLine("Invalid triangle, goodbye", degrees);
                    }
        }

        //Menu Choice 3
        //TEST CASE 4
        if (option == '3')
        {
            Console.WriteLine("what is the value of opposite?: ");
                input = Console.ReadLine();
            opp = int.Parse(Console.ReadLine());
            //determines value of opp

            Console.WriteLine("what is the value of hypotenuse?: ");
                input = Console.ReadLine();
            hyp = int.Parse(Console.ReadLine());
            //determines value of hypotenuse

            degrees = Math.Asin(opp, hyp);
            Console.WriteLine("The angle of this equation is: {0}", degrees);
            //formula

            //TEST CASE 5
            //input version 1
                if (opp == 5 && hyp == 6)
                {

                degrees = Math.Asin(opp, hyp);
                Console.WriteLine("The angle of this equation is: {0}", degrees);
                }

            //input version 2
            if (opp == 6 && hyp == 5)
            {

                degrees = Math.Asin(opp, hyp);
                Console.WriteLine("Invalid triangle, goodbye", degrees);
                }

        }

        //TEST 6
        if (option == default)
        {
            Console.WriteLine("INVALID selection, goodbye...");

        }*/
    }
}




