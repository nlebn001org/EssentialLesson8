using System;

namespace EssentialLesson8Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    //Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    //Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию.
    //Если сотрудник отработал больше положенных часов в месяц, то ему положена премия.

    class Program
    {
        static void Main(string[] args)
        {
            if (new Accountant().AskForBonus(Post.Manager, 200))
            {
                Console.WriteLine("Bonus was accepted.");
            }
            else
            {
                Console.WriteLine("Bonus was not accepted.");
            }
        }
    }
}
