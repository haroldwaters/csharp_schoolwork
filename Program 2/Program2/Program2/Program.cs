using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        const int NUM_COUNT = 3;
        static int reqCount = 0;

        static void Main(string[] args)
        {
            string[] strNums = new string[NUM_COUNT];
            float[] floatNums = new float[NUM_COUNT];
            double[] doubleNums = new double[NUM_COUNT];

            string[] choices = new string[4] { "Blue Whale","Lion's Mane Jellyfish","Armillaria Ostoyae","Giant Sequoia" };

            //float[] sortedFloatNums = new float[NUM_COUNT];

            Console.Title = "Program-2";

            requirementText();
            Console.WriteLine("This is Program-2");

            requirementText();
            Console.WriteLine("Please enter 3 floats!");

            for (int i = 0; i < floatNums.Length; ++i)
            {
                Console.Write("Number {0}: ",i+1);
                strNums[i] = Console.ReadLine();

                while (!(float.TryParse(strNums[i],out floatNums[i])))
                {
                    Console.Write("Please enter a valid number: ");
                    strNums[i] = Console.ReadLine();
                }
            
            }

            requirementText();
            Console.WriteLine($"You entered: {listNums(floatNums)}");
            Console.WriteLine($"{floatNums[0]} + {floatNums[1]} = {floatNums[0] + floatNums[1]}");
            Console.WriteLine($"{floatNums[1]} * {floatNums[2]} = {floatNums[1] * floatNums[2]}");
            Console.WriteLine($"{floatNums[2]} ÷ {floatNums[0]} = {floatNums[2] / floatNums[0]}");

            requirementText();
            Console.WriteLine("Implicitly casting numbers as doubles:");
            for(int i = 0; i < doubleNums.Length; ++i)
            {
                doubleNums[i] = floatNums[i];
                Console.WriteLine($"\t{doubleNums[i]} is of type {doubleNums[i].GetType()}");
            }

            requirementText();
            Console.WriteLine("Explicitly casting numbers as doubles:");
            for(int i = 0; i < doubleNums.Length; ++i)
            {
                doubleNums[i] = (double)floatNums[i];
                Console.WriteLine($"\t{doubleNums[i]} is of type {doubleNums[i].GetType()}");
            }

            requirementText();
            Console.WriteLine("Converting numbers to strings");
            for(int i = 0; i < doubleNums.Length; ++i)
            {
                strNums[i] = floatNums[i].ToString();
                Console.WriteLine($"\t{strNums[i]} is of type {strNums[i].GetType()}");
            }

            requirementText();
            Console.WriteLine("The largest living organism (by mass) belongs to which species?");
            foreach(string str in choices)
            {
                Console.WriteLine("\t {0}", str);
            }
            
            switch (Console.ReadLine().ToLower())
            {
                case "armillaria ostoyae":
                    Console.WriteLine("Correct! A mushroom of this type in the Malheur National Forest\n "+
                              "in the Blue Mountains of eastern Oregon, U.S. was found to be\n"+
                              "the largest fungal colony in the world, spanning 8.9 km2\n"+
                              "(2,200 acres) of area. It is estimated at over 605 million tons!");
                    break;
                default:
                    Console.WriteLine("Incorrect!");
                    break;
            }

            requirementText();
            Console.WriteLine($"Original number order : {listNums(floatNums)}");

            float temp; 

            if(floatNums[0] > floatNums[1])
            {
                temp = floatNums[0];
                floatNums[0] = floatNums[1];
                floatNums[1] = temp;
            }
            if(floatNums[0] > floatNums[2])
            {
                temp = floatNums[0];
                floatNums[0] = floatNums[2];
                floatNums[2] = temp;
            }
            if(floatNums[1] > floatNums[2])
            {
                temp = floatNums[1];
                floatNums[1] = floatNums[2];
                floatNums[2] = temp;
            }

            //Didn't notice the decision contructs condition for this requirement
            //at first, but I'm proud of my insertion sort so I'm leaving it in, 
            //albeit commented out.
            //sortedFloatNums = insertionSort(floatNums);

            Console.WriteLine($"Sorted number order : {listNums(floatNums)}");

            requirementText();
            Console.WriteLine("Thank you for running Program-2.");
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


        static float[] insertionSort(float[] floatNums)
        {
            float[] sortArr = new float[floatNums.Length];
            floatNums.CopyTo(sortArr, 0);

            for (int i = 0; i < sortArr.Length- 1; ++i)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if(sortArr[j] < sortArr[j-1])
                    {
                        float temp = sortArr[j - 1];
                        sortArr[j - 1] = sortArr[j];
                        sortArr[j] = temp;
                    }
                }
            }
            return sortArr;
        }
    }
}
