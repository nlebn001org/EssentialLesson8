using System;

namespace EssentialLesson8Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом.Используя перечисление,
    //создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю.

    class Program
    {
        static void Main(string[] args)
        {

            string print;
            string color;

            while (true)
            {
                Console.WriteLine("Type string");
                print = Console.ReadLine();
                Console.WriteLine("Type color: RED, BLUE, GREEN, CYAN");
                color = Console.ReadLine();

                switch (color.ToUpper())
                {
                    case "RED":
                        Printer.Print(print, (int)ColorsEnum.RED);
                        break;

                    case "BLUE":
                        Printer.Print(print, (int)ColorsEnum.BLUE);
                        break;

                    case "GREEN":
                        Printer.Print(print, (int)ColorsEnum.GREEN);
                        break;

                    case "CYAN":
                        Printer.Print(print, (int)ColorsEnum.CYAN);
                        break;

                    default:
                        Console.WriteLine("We dont have this color.");
                        break;

                }
            }
        }
    }
}
