using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static int reqCount = 0;

        static int lowPSISetting = 10;
        static int highPSISetting = 45;
        static int desiredPSI = 0;

        static void Main(string[] args)
        {
            Console.Title = "Program 5";

            requirementText();
            Console.WriteLine("Welcome to Program 5");

            requirementText();
            Console.WriteLine($"Instance fields lowPSISetting({lowPSISetting}), highPSISetting({highPSISetting}) and desiredPSI({desiredPSI}) exist");

            requirementText();
            Console.WriteLine($"Method ChangeAirPressure() exists");

            requirementText();
            Console.WriteLine($"lowPSISetting: {lowPSISetting}, highPSISetting: {highPSISetting}, desiredPSI: {desiredPSI}");
            desiredPSI = ChangeAirPressure(desiredPSI);
            requirementText();
            Console.WriteLine($"lowPSISetting: {lowPSISetting}, highPSISetting: {highPSISetting}, desiredPSI: {desiredPSI}");

            requirementText();
            Console.WriteLine("Class Alarm Exists");

            requirementText();
            string sound = "";
            Console.Write("Sound Alarm? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {

                while (!sound.Equals("NO"))
                {
                    Alarm.SoundAlarm();
                    Console.Write($"Alarm has been sounded {Alarm.GetAlarmCount()} times, sound again? Enter \"NO\" to stop ");
                    sound = Console.ReadLine();
                }
            }

            requirementText();
            Console.WriteLine("Thank you for running Program-5");
            Console.ReadKey(true);
        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }

        static int ChangeAirPressure(int desiredPSI = 0)
        {
            while (!(desiredPSI >= lowPSISetting && desiredPSI <= highPSISetting)) { 
              
                if(!(desiredPSI >= lowPSISetting && desiredPSI <= highPSISetting))
                {
                    Console.WriteLine($"\tDesired PSI {desiredPSI} is outside range {lowPSISetting}-{highPSISetting}");
                }

                Console.Write("\tPlese enter desired PSI: ");
                desiredPSI = int.Parse(Console.ReadLine());

                if (desiredPSI >= lowPSISetting && desiredPSI <= highPSISetting)
                {
                    Console.WriteLine($"\tDesired PSI {desiredPSI} is within acceptable range");
                }

                Console.Write("\tWould you like to change the low PSI setting (y/n)");
                string choice;
                choice = Console.ReadLine().ToLower();
                if (choice.StartsWith("y"))
                {
                    Console.Write("\tPlease enter new low PSI setting: ");
                    lowPSISetting = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tLow PSI setting set to {lowPSISetting}");
                }
            }
            return desiredPSI;
        }
    }
}
