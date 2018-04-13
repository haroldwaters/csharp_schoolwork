using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program1
    {
        static int reqCount = 0;

        static void Main(string[] args)
        {
            Console.Title = "Harold Waters Program-1";
            requirementText();
            Console.WriteLine("This is Program-1");
            
            requirementText();
            Console.WriteLine("You entered the following {0} names on the command line:", args.Length);

            requirementText();
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }

            requirementText();
            Console.WriteLine("Thank you for running Program-1.");

            Console.ReadKey(true);   
        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }
    }
}
