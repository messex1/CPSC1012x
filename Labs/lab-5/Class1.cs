

namespace Nov_18_Quiz5_Prep
{
    internal class Program
    {
        const int MAX_TEMP = 35;
        const int MIN_TEMP = -40;
        static void Main(string[] args)
        {
            int[][] Temperatures = null;
            int[] dataArray = null, generatedArray = null;


            bool exitProgram = false;
            string filePath = "d:\\Temperatures.txt";


            while (!exitProgram)
            {
                char selection;

                selection = Menu();
                switch (selection)
                {
                    case 'g':
                        Console.Write("Enter the size of the array you like to generate: ");
                        int size;
                        while (!int.TryParse(Console.ReadLine(), out size))
                        {
                            Console.Write("Invalid input, Enter the size of the array: ");
                        }

                        generatedArray = new int[size];

                        GenerateArray(generatedArray);

                        Console.WriteLine("Random array generated. Press any key to go back");
                        Console.ReadKey();
                        break;

                    case 'd':
                        //DisplayArray(generatedArray, Temperatures);
                        Temperatures = new int[2][];
                        if (dataArray == null)
                        {
                            Console.WriteLine("data not read from file, please use read first");
                        }
                        else
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                Temperatures[i] = new int[dataArray.Length];
                            }
                            DisplayArray(dataArray, Temperatures);
                        }

                        Console.WriteLine("Press any key to go back");
                        Console.ReadKey();
                        break;

                    case 's':
                        SaveArray(generatedArray);
                        Console.WriteLine("Array saved into file. Press any key to go back");
                        Console.ReadKey();
                        break;

                    case 'r':
                        int fileSize = GetFileSize(filePath);
                        dataArray = new int[fileSize];
                        ReadArray(dataArray, filePath);
                        Console.WriteLine("Initial reading process completed, press any key to go back...");
                        Console.ReadKey();
                        break;

                    case 'q':
                        exitProgram = true;
                        Console.WriteLine("Good bye");
                        break;
                    default:
                        break;
                }

            }
        }

        private static int GetFileSize(string filePath)
        {
            StreamReader sr = null;
            int i = 0;
            try
            {
                /*This is just to Count the number of temperatures in the file*/
                sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    i++;
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("No existing file found...");
            }
            finally
            {
                sr.Close();
            }
            return i;
        }

        private static void ReadArray(int[]? array, string filePath)
        {
            StreamReader sr = null;
            int i = 0;
            try
            {
                /*This is to read the actual data from the file*/
                sr = new StreamReader(filePath);
                i = 0;
                while (!sr.EndOfStream)
                {
                    array[i++] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("No existing file found...");
            }
            finally
            {
                sr.Close();
            }
        }

        private static void SaveArray(int[]? generatedArray)
        {
            string filePath = "d:\\Temperatures.txt";

            StreamWriter sw = new StreamWriter(filePath);

            for (int i = 0; i < generatedArray.Length; i++)
            {
                sw.WriteLine(generatedArray[i]);
            }
            sw.Close();
        }

        private static void DisplayArray(int[] array, int[][] temperatures)
        {
            Console.WriteLine("Celcius\t\tFahrenheit");
            for (int i = 0; i < array.Length; i++)
            {
                temperatures[0][i] = array[i];
                temperatures[1][i] = (int)(temperatures[0][i] * 9.0 / 5 + 32);
                Console.WriteLine("{0}\t\t{1}", temperatures[0][i], temperatures[1][i]);
            }

        }

        private static void GenerateArray(int[] generatedArray)
        {
            int size = 0;
            Random rnd = new Random();

            for (int i = 0; i < generatedArray.Length; i++)
            {
                //generates a random int between 0 and 200
                generatedArray[i] = rnd.Next(MIN_TEMP, MAX_TEMP + 1);
            }
        }


        static char Menu()
        {
            char option;

            Console.Clear();
            Console.WriteLine("G - Generate New Array");
            Console.WriteLine("D - Display Jagged Array");
            Console.WriteLine("S - Save to file");
            Console.WriteLine("R - Read from a file");
            Console.WriteLine("Q - Quit Program");
            Console.Write("Enter your option->");

            option = Console.ReadLine().ToLower().FirstOrDefault();
            while (option != 'g' && option != 'd' && option != 's' && option != 'r' && option != 'q')
            {
                Console.Write("Invalid Option. Enter your option->");
                option = Console.ReadLine().ToLower().FirstOrDefault();
            }

            return option;
        }
    }
}