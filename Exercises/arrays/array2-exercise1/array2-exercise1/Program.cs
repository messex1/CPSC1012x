namespace array2
{
    internal class Program
    {
        public static void Main(string[] args) { 

            static void GetUserNumbers(int[] anumbers)
                //The method will load user input numbers into the array and return the count of numbers entered.
            {  /*
                Function GetUserNumbers(Integer[ ] Numbers) As Int
                    The method will load user input numbers into the array and return the count ofnumbers entered.
                Function MeanAverageOfNumbers(Integer[ ] Numbers, Integer Count) As Integer
                The method will return the mean average of the numbers in the array*/
                int arraysize = 10;
                double[] numbers = new double[arraysize];
            
                double count = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write("input your numbers:  ");
                        numbers[i] = double.Parse(Console.ReadLine());
                    }
                    //read the elements from the array and add them to the variable count
                    for (int i = 0; i < arraysize; i++)
                    {
                        count += numbers[i];
                    }
                //Divide the sum by the number of elements
            
                Console.WriteLine("the count is {0}", count);
            }

            /*EXAMPLE ONLINE FOR LATER REFERENCE

              // C# code to get the number of
              // elements contained in List
                    using System;
                    using System.Collections.Generic;

                    class Geeks {

                   // Main Method
                        public static void Main()
                        {

                   // Creating a List of integers
                            List<int> firstlist = new List<int>();

                   // adding elements in firstlist
                            for (int i = 4; i < 10; i++) {
                                firstlist.Add(i * 2);
                            }

                   // To get the number of
                   // elements in the List
                            Console.WriteLine(firstlist.Count);
                        }
                    }*/

        }
    }
}