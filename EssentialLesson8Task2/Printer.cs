using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson8Task2
{
    static class Printer
    {

        public static void Print(string str, int color)
        {

            switch (color)
            {
                case (int)ColorsEnum.RED:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case (int)ColorsEnum.BLUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case (int)ColorsEnum.GREEN:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case (int)ColorsEnum.CYAN:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
     
            }
            Console.WriteLine(str);
            resetConsole();

        }

        public static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
