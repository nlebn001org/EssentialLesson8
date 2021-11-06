using System;

namespace EssentialLesson8Task1
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.

    class Program
    {
        static void Main(string[] args)
        {

            DateTime timeNow = DateTime.Now;
            DateTime birthDay = new DateTime();
            DateTime nextBirthDay;
            TimeSpan spanDays;

            int currentYear = timeNow.Year;

            string str;
            int num;
            int year;
            int month;
            int day;
            string birthdayStr;

            while (true)
            {
                Console.WriteLine("Type a year of your birth.");

                while (true)
                {
                    str = Console.ReadLine();
                    if (int.TryParse(str, out num))
                    {
                        if (num < currentYear && num > 1900)
                        {
                            year = num;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect year, try again.");
                            continue;
                        }
                    }
                }

                Console.WriteLine("Type a month of your birth.");

                while (true)
                {
                    str = Console.ReadLine();
                    if (int.TryParse(str, out num))
                    {
                        if (num < 13 && num > 0)
                        {
                            month = num;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect month, try again.");
                            continue;
                        }
                    }
                }

                Console.WriteLine("Type a day of your birth.");
                while (true)
                {
                    str = Console.ReadLine();
                    if (int.TryParse(str, out num))
                    {
                        if (num < 32 && num > 0)
                        {
                            day = num;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect day, try again.");
                            continue;
                        }
                    }
                }

                birthdayStr = $"{year}/{month}/{day}";                      // string for DateTime validation

                if (DateTime.TryParse(birthdayStr, out birthDay))
                {
                    Console.WriteLine($"Your birthday is: {birthDay:d}");

                    if (birthDay.Month < timeNow.Month && birthDay.Day < timeNow.Day)
                    {
                        nextBirthDay = new DateTime(timeNow.Year, birthDay.Month, birthDay.Day);
                        spanDays = nextBirthDay - timeNow;
                        Console.WriteLine($"Your next birthday will be in {spanDays.Days} days");
                    }
                    else
                    {
                        nextBirthDay = new DateTime(timeNow.Year + 1, birthDay.Month, birthDay.Day);
                        spanDays = nextBirthDay - timeNow;
                        Console.WriteLine($"Your next birthday will be in {spanDays.Days} days");
                    }
                }
                else
                {
                    Console.WriteLine("Date is not validated, try again.");

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
