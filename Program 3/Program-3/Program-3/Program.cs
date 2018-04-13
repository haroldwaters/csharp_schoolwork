using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    class Program
    {
        public static int NUM_COUNT = 5;
        public static int reqCount = 0;

        static void Main(string[] args)
        {
            String strNum = string.Empty;
            Double[] doubleNums = new Double[NUM_COUNT];

            Double sumNum = 0;
            Double avgNum = 0;
            Double lowestNum = 0;
            Double highestNum = 0;

            int innerArrLength = 2;
            String[,] daysOfWeek = new String[NUM_COUNT,innerArrLength];

            Console.Title = "Program-3";
            requirementText();
            Console.WriteLine("This is Program-3");

            requirementText();
            Console.WriteLine("Please enter 5 doubles!");

            requirementText();
            for (int i = 0; i < doubleNums.Length; ++i)
            {
                do
                {
                    Console.Write("Number {0}: ", i + 1);
                    strNum = Console.ReadLine();
                    if (!double.TryParse(strNum, out doubleNums[i]))
                    {
                        Console.WriteLine("Please enter a valid number!");
                    }
                }
                while (!double.TryParse(strNum, out doubleNums[i]));
            }

            requirementText();
            Console.WriteLine(listNums(doubleNums));
            lowestNum = doubleNums[0];
            highestNum = doubleNums[0];
            for(int i = 0; i < doubleNums.Length; ++i)
            {
                sumNum += doubleNums[i];
                avgNum += doubleNums[i] / doubleNums.Length ;

                lowestNum = (doubleNums[i] < lowestNum) ? doubleNums[i]: lowestNum;
                highestNum = (doubleNums[i] > highestNum) ? doubleNums[i]: highestNum;
            }

            Console.WriteLine("Sum: {0}", sumNum);
            Console.WriteLine("Average: {0}", avgNum);
            Console.WriteLine("Lowest Number: {0}", lowestNum);
            Console.WriteLine("Highest Number: {0}", highestNum);
            Console.WriteLine(daysOfWeek.GetLength(0));

            requirementText();
            for (int i = 0; i < daysOfWeek.GetLength(0); i++)
            {
                double doubleTemp;
                do
                {

                    Console.Write("Please enter the day of the week: ");
                    daysOfWeek[i, 0] = Console.ReadLine();
                    if(daysOfWeek[i, 0].Length < 1)
                    {
                        Console.WriteLine("Please enter a valid day!");
                    }
                } while (daysOfWeek[i, 0].Length < 1);

                for (int j = 1; j < innerArrLength; ++j)
                {
                    do
                    {
                        Console.Write("Please enter rainfall information for {0}: ",daysOfWeek[i,0]);
                        daysOfWeek[i, j] = Console.ReadLine();

                        if (!double.TryParse(daysOfWeek[i, j], out doubleTemp))
                        {
                            Console.WriteLine("Please enter a valid number!");
                        }
                    } while (!(double.TryParse(daysOfWeek[i, j], out doubleTemp)));

                }
            }

            requirementText();
            for(int i =0; i < daysOfWeek.GetLength(0); i++)
            {
                Console.WriteLine("{0}: {1}", daysOfWeek[i, 0], daysOfWeek[i, 1]);
            }
            sumNum = 0;
            avgNum = 0;
            lowestNum = Double.Parse(daysOfWeek[0,1]);
            highestNum = Double.Parse(daysOfWeek[0,1]);
            double temp;
            
            for(int i = 0; i < daysOfWeek.GetLength(0); ++i)
            {
                temp = Double.Parse(daysOfWeek[i, 1]);
                sumNum += temp;
                avgNum += temp / daysOfWeek.Length ;

                lowestNum = (temp < lowestNum) ? temp: lowestNum;
                highestNum = (temp > highestNum) ? temp: highestNum;
            }

            Console.WriteLine("Sum: {0}", sumNum);
            Console.WriteLine("Average: {0}", avgNum);
            Console.WriteLine("Lowest Number: {0}", lowestNum);
            Console.WriteLine("Highest Number: {0}", highestNum);

            requirementText();
            byte[][] jaggedArray = new byte[2][];
            jaggedArray[0] = new byte[5] {0x0048,0x0065,0x006c,0x006c,0x006f};
            jaggedArray[1] = new byte[4] {0x0044,0x0061,0x0076,0x0065};
            Console.WriteLine(System.Text.Encoding.ASCII.GetString(jaggedArray[0]));
            Console.WriteLine(System.Text.Encoding.ASCII.GetString(jaggedArray[1]));

            requirementText();
            Console.WriteLine("Thank you for running Program-3");
            Console.ReadKey(true);
        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }

        static string listNums<T>(T[] nums)
        {
            string outStr = string.Empty;

            if (nums.Length > 0)
            {

                outStr = nums[0].ToString();

                for (int i = 1; i < nums.Length; ++i)
                {
                    outStr += ", " + nums[i].ToString();
                }
            }
            return outStr;
        }

    }
}
