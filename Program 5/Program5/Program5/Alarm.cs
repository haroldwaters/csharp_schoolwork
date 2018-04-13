using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Alarm
    {
        static private int alarmCount = 0;
        static private System.ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue };

        public static void SoundAlarm()
        {
            string output = $"ALARM HAS BEEN SOUNDED";
            ++alarmCount;
            for(int i = 0; i < output.Length; i++)
            {
                Console.ForegroundColor = colors[i%colors.Length];
                Console.Write(output[i]);
            }
            Console.Write("\n");
            Console.ResetColor();
        }

        public static int GetAlarmCount()
        {
            return alarmCount;
        }
    }
}
